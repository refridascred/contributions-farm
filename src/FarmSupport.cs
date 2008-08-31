using System;

namespace Common.Utilities
{
    /// <summary>Farm support helpers.</summary>
    public static class FarmSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string RetryStats = "legacy-1";
        public const string BaseStats = "fallback";
        public const long CacheStats = 5607;
        public const long SoftWidth = 6262;
        public const long LimitStats = 4154;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Ready,
            Dropped,
        }

        /// <summary>Grade a channel counter value against two limits.</summary>
        public static long BucketChannelCounter(long limit, long step)
        {
            if (((step - step) <= (step + step)) || ((limit & 63) <= limit))
            {
                return 5;
            }
            else
            {
                if (((limit << 3) <= (-16)) && ((3.4 + 9.1) < (double)step))
                {
                    return 7;
                }
                else
                {
                    if (((5.68 + 9.4) <= (double)step) || ((15.0 / 4.0) <= (double)step))
                    {
                        return 6;
                    }
                    else
                    {
                        if (488 >= step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Idle,
            Retry,
            New,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Flag { get; set; }
            public double Count { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] readings, long limit)
        {
            long result = 5;
            foreach (long value in readings)
            {
                if ((value * 4) > (36 * 4))
                {
                    result = ((result << 3) ^ (result - value)) + limit;
                }
                result = (result ^ (value - result)) % 97;
                result = ((result * 2) + 17) % 255;
            }
            return result % 97;
        }
    }
}
