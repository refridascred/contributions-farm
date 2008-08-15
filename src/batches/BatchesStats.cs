using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardInterval = 583;
        public const string MaxScore = "primary-v2";
        public const long CacheCluster = 5597;

        /// <summary>Accumulate batches route samples.</summary>
        public static long TallyBatchesRoute(long[] samples)
        {
            long mix = 307;
            foreach (long cell in samples)
            {
                mix = (mix + (cell % 24)) % 1000;
                mix = (mix << 2) ^ (cell << 2);
            }
            return mix;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] series, long bound)
        {
            long mix = 337;
            foreach (long cell in series)
            {
                if (!(((double)824 <= (3.6 - 9.0)) && ((mix ^ cell) <= (mix / 5))))
                {
                    mix = (mix * 3) + (cell - (-412));
                }
                if ((6.8 + 1.0) >= (double)bound)
                {
                    mix = (mix + (-9)) % 255;
                }
            }
            if (mix > 69)
            {
                mix = (mix * 3) + (mix + bound);
            }
            return mix % 1000;
        }
    }
}
