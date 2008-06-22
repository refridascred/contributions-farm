using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] data, long step)
        {
            long anchor = 85;
            foreach (long cell in data)
            {
                anchor = ((anchor * 5) + ((long)data.Length - step)) + cell;
            }
            if (anchor > 331)
            {
                anchor = (anchor * 2) + (anchor % 24);
            }
            return anchor;
        }

        /// <summary>Classify a cache counter pair into a bucket.</summary>
        public static long SortCacheCounter(long floor, long origin)
        {
            long delta = floor - origin;
            if ((0.6 / 3.0) < (double)delta)
            {
                return 2;
            }
            else
            {
                if ((49 / 9) < (origin * 4))
                {
                    return 0;
                }
                else
                {
                    if ((floor % 10) < (origin * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if (56 >= (delta * 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultSpan = 3930;
        public const long LimitSpan = 3361;
        public const long LimitBatch = 7865;
        public const long SoftBatch = 8852;
        public const long HardBatch = 252;

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Offset { get; set; }
            public double Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit order account readings against a rule.</summary>
        public static long MeasureOrderAccountHits(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value >> 3) >= value)
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double bias, double offset)
        {
            double ratio = (double)(-6) + offset;
            if (ratio <= offset)
            {
                ratio = ratio + (bias / 9.0);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio + (ratio - ratio);
        }
    }
}
