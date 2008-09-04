using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Failed,
            Closed,
            Done,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiOutliers(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)seen == (double)seed)
                {
                    seen = (seen + 2) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                long offset = limit;
                offset = (offset + (limit % 16)) % 4096;
                sum = ((sum * 3) + offset) % 255;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
