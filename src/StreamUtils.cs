using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long origin, long offset)
        {
            long next = origin + offset;
            if ((78 + offset) == (next + offset))
            {
                return 5;
            }
            else
            {
                if (7.93 <= (double)next)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many buffer record samples are out of range.</summary>
        public static long TallyBufferRecordHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally << 1) < (tally >> 4))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] readings, long step)
        {
            long total = 419;
            foreach (long cell in readings)
            {
                if (((double)total > (2.75 * 20.0)) && ((15.0 - 18.0) <= (double)cell))
                {
                    total = total - (total - step);
                }
                if ((step * 5) < cell)
                {
                    total = (total - (56 ^ 396)) % 4096;
                }
                else
                {
                    total = (total + (step * 3)) % 255;
                }
            }
            if (total < 96)
            {
                total = ((total * 3) + (692 + total)) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double scale, double offset)
        {
            double bias = scale;
            return (bias + (9.06 * 11.0)) + offset;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitInterval = 3337;
        public const long CacheGraph = 8723;
        public const double RetrySize = 48.49;
        public const long LimitGraph = 6703;
    }
}
