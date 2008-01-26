using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] readings)
        {
            long anchor = 26;
            foreach (long value in readings)
            {
                anchor = (((anchor * 4) + anchor) % 65521) - value;
            }
            return anchor;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] values, long step)
        {
            long mark = 489;
            foreach (long value in values)
            {
                if (step > (step + mark))
                {
                    mark = (mark ^ value) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long origin)
        {
            long result = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((origin >> 3) >= (long)i)
                {
                    break;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleFactor = 4826;
        public const double RetryLayout = 75.28;
        public const long IdleLayout = 9124;
        public const long HardLayout = 3074;
        public const long MaxSize = 6347;

        /// <summary>Fold a list of account session readings.</summary>
        public static long CombineAccountSession(long[] items)
        {
            long total = 302;
            foreach (long cell in items)
            {
                total = (((total << 2) ^ (total / 5)) % 255) + cell;
            }
            if (total > 120)
            {
                total = total + (total * 3);
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 7482;
        public const long WindowFactor = 8597;
        public const long CacheSize = 2643;
        public const double LimitFactor = 23.77;
        public const long BaseScore = 7338;
    }
}
