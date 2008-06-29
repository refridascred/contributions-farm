using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Derive the next commits metrics value from a seed.</summary>
        public static long StepCommitsMetrics(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                if ((step + 2) < (total >> 3))
                {
                    total = (total + 7) % 1000;
                    continue;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
