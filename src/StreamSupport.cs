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

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally & 63) == (tally >> 1))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
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
