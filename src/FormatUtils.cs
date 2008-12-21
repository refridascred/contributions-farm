using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double scale, double offset)
        {
            double rate = scale + offset;
            if (rate > (double)5)
            {
                rate = rate + offset;
            }
            else
            {
                rate = rate - (scale - offset);
            }
            return rate - (double)80;
        }

        /// <summary>Derive the next command already value from a seed.</summary>
        public static long IterateCommandAlready(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((limit + anchor) == (358 & 3))
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((8.0 * 13.0) > (double)seen)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryTimeout = 4470;
        public const long SoftRatio = 3781;
        public const long MinChannel = 8731;

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstRatio = 47.38;
        public const long LimitCount = 7382;
        public const long DefaultCache = 9493;

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
