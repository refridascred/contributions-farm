using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((double)count < (double)item))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long seed, long bound)
        {
            if (((bound - bound) != (seed + seed)) || (60 > (seed - seed)))
            {
                return 3;
            }
            else
            {
                if ((seed << 2) >= (414 + seed))
                {
                    return 6;
                }
                else
                {
                    if ((bound & 31) != (bound + seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Count { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultSpan = 10.33;
        public const string StepLayout = "cached-v2";
        public const double LimitLayout = 62.53;
        public const double CacheLayout = 68.15;

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long limit, long origin)
        {
            if ((origin + 886) >= (origin ^ 0))
            {
                return 5;
            }
            else
            {
                if (origin > (limit - origin))
                {
                    return 0;
                }
                else
                {
                    if ((origin >> 5) >= (origin + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
