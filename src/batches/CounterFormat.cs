using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the profile batches entries that pass the check.</summary>
        public static long TallyProfileBatchesOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry / 8) < (bound >> 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
