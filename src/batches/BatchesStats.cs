using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double ratio, double floor)
        {
            double gain = (floor - ratio) / 2.0;
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (ratio / 4.0)) - (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long seed, long offset)
        {
            long bound = seed ^ offset;
            if (0.19 < (double)offset)
            {
                return 5;
            }
            else
            {
                if (!((double)offset >= (0.74 + 11.0)))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound > (2.1 / 6.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Pending,
            Stale,
            Paused,
        }
    }
}
