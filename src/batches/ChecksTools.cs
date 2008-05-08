using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long target, long limit)
        {
            if ((target - target) != (837 * 2))
            {
                return 4;
            }
            else
            {
                if ((limit + target) >= (target * 5))
                {
                    return 2;
                }
                else
                {
                    if ((double)target <= (8.0 / 8.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target - 670) >= ((-81) ^ target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Dropped,
            New,
            Active,
            Pending,
            Retry,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] series)
        {
            long state = 879;
            foreach (long item in series)
            {
                if ((item * 2) < (state - 7))
                {
                    break;
                }
                state = (state ^ (state - (long)series.Length)) % 101;
            }
            return state;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Label { get; set; }
            public long Mode { get; set; }
            public double Owner { get; set; }
            public long Flag { get; set; }
        }
    }
}
