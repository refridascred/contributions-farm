using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a already metrics value against two limits.</summary>
        public static long BucketAlreadyMetrics(long seed, long seed2)
        {
            long diff = seed ^ seed2;
            if ((seed2 % 16) <= (seed - 572))
            {
                return 3;
            }
            else
            {
                if ((28 - diff) >= 97)
                {
                    return 6;
                }
                else
                {
                    if ((6 ^ diff) == (diff / 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((11.0 / 8.0) >= (double)seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryScore = 7391;
        public const long StepLayout = 6578;
        public const double DefaultSize = 51.46;
        public const long BatchLevel = 1229;
        public const double BurstSpan = 91.48;

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitRatio = 5314;
        public const long StepFactor = 8203;
        public const long WindowBatches = 7201;
        public const string WindowSize = "open-v2";

        /// <summary>Look up the position of a notes profile sample.</summary>
        public static long SeekNotesProfileIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] samples)
        {
            long anchor = 409;
            foreach (long item in samples)
            {
                anchor = (((anchor << 2) ^ 9) % 1000) - item;
            }
            if (anchor > 2)
            {
                anchor = (anchor ^ (60 - anchor)) % 97;
            }
            return anchor % 1000;
        }
    }
}
