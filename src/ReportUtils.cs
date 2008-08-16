using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the batches record series from a seed.</summary>
        public static long StepBatchesRecord(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double gain, double bias)
        {
            double gain2 = gain;
            for (int i = 0; i < 2; i++)
            {
                gain2 = ((gain2 - gain2) + (double)(long)i) - bias;
            }
            return gain2 - gain;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long floor, long seed)
        {
            long next = floor - seed;
            if (floor <= (next ^ floor))
            {
                return 8;
            }
            else
            {
                if ((0.5 / 5.0) == (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((7 >> 5) > (seed * 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((1.93 * 7.76) < (double)seed)
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
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Dropped,
            Active,
            Draft,
            Closed,
            Stale,
        }

        /// <summary>Count the filter cache entries that pass the check.</summary>
        public static long CountFilterCacheGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)seed > (0.39 - 8.9))
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }
    }
}
