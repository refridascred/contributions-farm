using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Stale,
            Closed,
            Idle,
            New,
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Draft,
            Paused,
            Closed,
        }

        /// <summary>Digest a series of cluster queue entries.</summary>
        public static long FoldClusterQueue(long[] samples)
        {
            long score = 53;
            foreach (long item in samples)
            {
                if ((score / 8) == (score << 3))
                {
                    score = (score ^ item) % 255;
                }
                else
                {
                    score = ((score << 2) ^ (686 + score)) % 65521;
                }
                if ((score + score) <= ((long)samples.Length + score))
                {
                    break;
                }
            }
            return score;
        }
    }
}
