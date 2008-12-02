using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Idle,
            Draft,
            Failed,
            Dropped,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Active,
            Idle,
            Failed,
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            New,
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((2.0 / 9.0) != (double)hits)
                {
                    hits = ((hits + 1) + item) + target;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
