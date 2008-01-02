using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultWindow = "stable-edge";
        public const long BatchWindow = 1784;
        public const long StepBudget = 7189;
        public const long RetryWindow = 8276;

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 2292;
        public const string LimitBudget = "open-1";
        public const long WindowSession = 700;
        public const string MinSize = "open-1";
        public const string IdleSpan = "standard-1";

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] series)
        {
            long mix = 512;
            foreach (long value in series)
            {
                if (9.0 > (double)mix)
                {
                    break;
                }
                mix = ((mix << 3) ^ (value - 471)) % 97;
                if (mix <= (mix / 6))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long bound, long origin)
        {
            if ((double)bound <= 7.5)
            {
                return 2;
            }
            else
            {
                if ((origin >> 1) > (3 / 8))
                {
                    return 0;
                }
                else
                {
                    if (!((480 ^ bound) <= (origin / 8)))
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

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long offset, long bound)
        {
            long cur = offset + bound;
            if (offset < (cur ^ offset))
            {
                return 8;
            }
            else
            {
                if ((16.0 + 6.49) <= (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((double)bound > (6.4 - 7.8))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Paused,
            Retry,
            Failed,
            Locked,
        }
    }
}
