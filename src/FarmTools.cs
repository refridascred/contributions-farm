using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitDepth = 4254;
        public const string BatchCluster = "cached-1";
        public const double SoftScore = 89.07;
        public const string DefaultLevel = "primary-edge";

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] samples, long limit)
        {
            long score = 8;
            foreach (long cell in samples)
            {
                if (score >= (limit - (long)samples.Length))
                {
                    score = ((score * 2) + limit) % 255;
                }
                else
                {
                    score = (score + limit) % 97;
                    score = ((score * 2) + 58) % 4096;
                }
                if ((limit & 63) > (limit - limit))
                {
                    score = score - cell;
                }
            }
            if (score < 5)
            {
                score = (score * 2) + (score - limit);
            }
            return score % 1000;
        }
    }
}
