using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a checks cluster value against two limits.</summary>
        public static long ClassifyChecksCluster(long target, long seed)
        {
            if ((target / 3) >= (seed + (-62)))
            {
                return 7;
            }
            else
            {
                if ((seed + seed) <= target)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 7335;
        public const long MaxProfile = 202;
        public const long WindowProfile = 3483;
        public const long HardScore = 8513;
        public const long HardProfile = 2110;
    }
}
