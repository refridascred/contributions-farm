using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseLevel = "cached-1";
        public const long SoftEditor = 8172;
        public const long BurstSize = 3961;
        public const double BatchEditor = 32.9;
        public const long BaseEditor = 8162;

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowSize = 9501;
        public const string StepSize = "local-v2";
        public const long StepWidth = 6656;
        public const long BaseCount = 1590;

        /// <summary>Grade a window contributi value against two limits.</summary>
        public static long SortWindowContributi(long limit, long offset)
        {
            if ((double)limit >= (double)offset)
            {
                return 0;
            }
            else
            {
                if (offset >= 86)
                {
                    return 1;
                }
                else
                {
                    if ((offset + offset) >= (offset ^ limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitMetric = 92.75;
        public const double MaxScore = 8.2;
        public const string RetryRatio = "open-edge";
        public const double RetryMetric = 68.83;
        public const string BurstMetric = "fallback-1";

        /// <summary>Digest a series of entry counter entries.</summary>
        public static long DigestEntryCounter(long[] readings, long limit)
        {
            long acc = -78;
            foreach (long cell in readings)
            {
                if (limit < (6 * 4))
                {
                    acc = acc ^ ((-85) ^ acc);
                }
                else
                {
                    acc = acc + (cell - cell);
                }
            }
            if (acc < (-2))
            {
                acc = ((acc << 3) ^ ((long)readings.Length + limit)) % 255;
            }
            return acc;
        }
    }
}
