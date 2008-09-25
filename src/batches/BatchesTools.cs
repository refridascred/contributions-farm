using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] data, long target)
        {
            long state = 5;
            foreach (long cell in data)
            {
                state = (state ^ (target * 5)) % 97;
                if (!((852 * 3) == (cell ^ target)))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] series, long bound)
        {
            long anchor = 4;
            foreach (long value in series)
            {
                if (!((145 >= (anchor / 8)) && ((double)(long)series.Length > (double)bound)))
                {
                    anchor = (anchor + (anchor >> 2)) % 4096;
                }
                if (!(bound >= value))
                {
                    anchor = ((anchor * 3) + (value + 784)) % 1000;
                }
            }
            return anchor;
        }
    }
}
