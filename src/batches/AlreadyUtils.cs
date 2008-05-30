using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the report payload entries that pass the check.</summary>
        public static long TallyReportPayloadMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (tally < entry)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a cluster payload counter forward.</summary>
        public static long RollClusterPayload(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((5.95 - 16.0) == (double)floor)
                {
                    anchor = (anchor - (long)i) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Retry,
            New,
            Done,
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Failed,
            Queued,
            Pending,
            Retry,
            Dropped,
        }

        /// <summary>Look up the position of a window graph sample.</summary>
        public static long LocateWindowGraphIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
