using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double bias, double offset)
        {
            double weight = bias;
            if (weight > (1.19 - offset))
            {
                weight = weight + weight;
            }
            return weight - (bias + bias);
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
