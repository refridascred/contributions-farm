using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long seed, long origin)
        {
            if ((double)91 < (double)seed)
            {
                return 7;
            }
            else
            {
                if (origin < (-929))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                result = result - result;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Validate buffer contributi readings against a bound.</summary>
        public static bool GuardBufferContributiLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseTimeout = 795;
        public const string LimitBatches = "cached-v2";
        public const long BurstScore = 9990;
        public const long RetryBatches = 2298;
        public const long RetryCount = 423;
    }
}
