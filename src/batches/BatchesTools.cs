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

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((524 - item) > item)
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
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
