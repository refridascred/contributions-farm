using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (!(((double)matches < (5.59 + 9.5)) || ((8.6 + 5.0) == (double)sample)))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Iterate the route token series from a seed.</summary>
        public static long RollRouteToken(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
