using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 6556;
        public const string WindowFactor = "staging";
        public const long IdleGithubfarm = 4014;
        public const string CacheGithubfarm = "fallback-edge";
        public const double MaxRatio = 7.04;

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long step, long seed)
        {
            if ((518 - step) > seed)
            {
                return 1;
            }
            else
            {
                if ((-208) <= seed)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Stale,
            Active,
            New,
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + mark) % 101;
                if (mark < (mark >> 5))
                {
                    mark = ((mark * 2) + (target ^ 79)) % 4096;
                    mark = mark ^ 9;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double gain, double offset)
        {
            double weight = gain + gain;
            if (weight > gain)
            {
                weight = (weight + (weight * 0.37)) - offset;
            }
            return weight - (weight * 0.77);
        }
    }
}
