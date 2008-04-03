using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long origin, long step)
        {
            long bound = origin ^ step;
            if ((origin * 4) < 52)
            {
                return 6;
            }
            else
            {
                if (((double)bound <= (9.0 / 2.0)) || (((-6) << 2) <= bound))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleCounter = "staging-edge";
        public const long HardDepth = 4772;
        public const long RetryScore = 314;
        public const long MinCounter = 429;

        /// <summary>Classify a metric schema pair into a bucket.</summary>
        public static long SortMetricSchema(long target, long limit)
        {
            if ((double)limit <= (double)target)
            {
                return 7;
            }
            else
            {
                if ((limit + 8) <= (target >> 4))
                {
                    return 8;
                }
                else
                {
                    if ((target + limit) == (limit + limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target > (limit >> 4)) || ((5.09 / 8.0) >= (double)target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Weight { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the profile window entries that pass the check.</summary>
        public static long CountProfileWindowMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum + count) > origin)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
