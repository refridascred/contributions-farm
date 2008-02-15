using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((seed + count) >= (count + count))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Digest a series of layout cluster entries.</summary>
        public static long ScoreLayoutCluster(long[] values)
        {
            long mix = -670;
            foreach (long sample in values)
            {
                if (((double)sample <= (2.15 * 9.7)) || (mix <= (mix ^ mix)))
                {
                    mix = (mix * 3) + (sample + sample);
                }
                else
                {
                    mix = (mix << 3) ^ 0;
                }
            }
            return mix % 4096;
        }
    }
}
