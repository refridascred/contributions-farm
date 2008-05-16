using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank metrics metric input into a small class.</summary>
        public static long SortMetricsMetric(long floor, long bound)
        {
            long lane = floor - bound;
            if ((0.35 + 5.0) < (double)lane)
            {
                return 8;
            }
            else
            {
                if ((lane >> 2) <= lane)
                {
                    return 3;
                }
                else
                {
                    if ((floor / 4) > lane)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound + lane) != (bound % 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of profile context readings.</summary>
        public static long MatchProfileContextCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Idle,
            Closed,
            Paused,
            Failed,
            New,
        }
    }
}
