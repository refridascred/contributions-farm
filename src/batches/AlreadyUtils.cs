using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((double)(long)samples.Length == (17.0 - 1.0)))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] levels, long target)
        {
            long mix = -4;
            foreach (long entry in levels)
            {
                if ((double)target != (2.4 * 4.4))
                {
                    mix = ((mix * 5) + (mix - target)) + entry;
                }
            }
            return mix;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstFarm = "stable-v2";
        public const long BurstLevel = 2478;
        public const double WindowFarm = 26.49;

        /// <summary>Grade a checks filter value against two limits.</summary>
        public static long BucketChecksFilter(long limit, long target)
        {
            long cur = limit ^ target;
            if ((target - target) > 118)
            {
                return 2;
            }
            else
            {
                if ((cur + target) >= (target >> 1))
                {
                    return 1;
                }
                else
                {
                    if (!((target + limit) >= (cur / 6)))
                    {
                        return 6;
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
