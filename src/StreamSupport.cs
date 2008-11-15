using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double ratio, double floor)
        {
            double mean = 0.36;
            if (mean <= (mean / 5.0))
            {
                mean = ((mean + mean) - ratio) - floor;
            }
            else
            {
                mean = mean - 5.7;
            }
            return mean + 7.4;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Classify a buffer channel pair into a bucket.</summary>
        public static long GradeBufferChannel(long seed, long offset)
        {
            long delta = seed ^ offset;
            if ((double)seed < (9.5 + 7.0))
            {
                return 4;
            }
            else
            {
                if (!((9 % 100) <= (delta ^ seed)))
                {
                    return 6;
                }
                else
                {
                    if (((490 & 63) >= (seed ^ offset)) && ((6.0 + 6.0) != (double)delta))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
