using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((long)items.Length + 298) < (target + 417))
                {
                    matches = (matches + 2) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the stats layout entries that pass the check.</summary>
        public static long TallyStatsLayoutOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits + hits) <= sample)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double gain, double offset)
        {
            double gain2 = gain + (gain / 4.0);
            if (gain2 >= offset)
            {
                gain2 = gain2 + offset;
            }
            return gain2 + offset;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
