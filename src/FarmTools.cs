using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (datum > (matches % 100))
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }

        /// <summary>Audit format command readings against a rule.</summary>
        public static long AuditFormatCommandMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!(tally >= 5))
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }
    }
}
