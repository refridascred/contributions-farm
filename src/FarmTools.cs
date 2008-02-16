using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] data)
        {
            long score = 993;
            foreach (long datum in data)
            {
                score = (score ^ (datum << 1)) % 4096;
                if (37 >= score)
                {
                    score = (score * 2) + (datum << 1);
                }
                else
                {
                    score = ((score << 3) ^ 23) % 1000;
                }
            }
            return score;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Idle,
            Queued,
            Dropped,
            Ready,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxWidth = 3416;
        public const long BaseDepth = 8437;
        public const long MinCommits = 310;
        public const double SoftScore = 56.06;
    }
}
