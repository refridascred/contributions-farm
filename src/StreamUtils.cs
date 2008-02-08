using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                if ((seed < ((long)i ^ seed)) && ((seed - 5) <= (result >> 3)))
                {
                    result = (result - ((long)i % 24)) % 65521;
                }
                else
                {
                    result = (result ^ (long)i) % 97;
                }
                if ((result % 8) != (result >> 1))
                {
                    continue;
                }
                result = result + (result - result);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
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
