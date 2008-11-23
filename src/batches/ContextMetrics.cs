using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long floor, long target)
        {
            long offset = floor ^ target;
            if (((floor - offset) == (3 + target)) && (floor < (9 / 8)))
            {
                return 2;
            }
            else
            {
                if (!((target << 1) != (floor & 7)))
                {
                    return 1;
                }
                else
                {
                    if (((94 << 3) <= offset) && (545 >= (offset / 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinSpan = 5089;
        public const string BatchEditor = "cached-1";
        public const long RetryScore = 7639;

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Draft,
            Pending,
            Done,
        }
    }
}
