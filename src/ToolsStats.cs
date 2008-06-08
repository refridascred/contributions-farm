using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] readings, long seed)
        {
            long carry = 90;
            foreach (long item in readings)
            {
                carry = (carry + (item >> 2)) + seed;
            }
            return carry % 97;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long seed, long limit)
        {
            long delta = seed ^ limit;
            if ((limit + delta) != (seed ^ (-3)))
            {
                return 0;
            }
            else
            {
                if (limit <= (24 ^ 583))
                {
                    return 4;
                }
                else
                {
                    if (14.0 <= (double)delta)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double gain, double floor)
        {
            double bias = (floor * 7.6) * 6.0;
            if (bias < 20.0)
            {
                bias = (bias + (double)1) + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (double)35) - (double)(long)i;
            }
            return bias + (double)295;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long mark = 677;
            foreach (long item in levels)
            {
                mark = mark - (item * 3);
                if (item <= (484 + item))
                {
                    mark = mark - ((-9) ^ mark);
                }
            }
            if (mark > 2)
            {
                mark = mark + mark;
            }
            return mark % 4096;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Pending,
            New,
            Active,
            Dropped,
            Idle,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
