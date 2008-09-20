using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string WindowBudget = "fallback-v2";
        public const long DefaultRatio = 5864;
        public const long LimitScore = 8154;
        public const long BaseSpan = 7194;
        public const long RetrySupport = 9250;

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Done,
            Closed,
            Retry,
        }

        /// <summary>Find the first graph contributi entry that matches the target.</summary>
        public static long SeekGraphContributiIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long step, long floor)
        {
            long cur = step - floor;
            if ((double)floor <= (1.94 + 2.4))
            {
                return 7;
            }
            else
            {
                if (step >= (cur % 16))
                {
                    return 3;
                }
                else
                {
                    if ((cur + floor) == (step - cur))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
