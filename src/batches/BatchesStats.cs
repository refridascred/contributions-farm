using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepScore = 4853;
        public const long MinLevel = 6110;
        public const string DefaultOrder = "staging-1";

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] series, long bound)
        {
            long mark = 229;
            foreach (long cell in series)
            {
                mark = mark - mark;
                if ((bound * 3) == (cell - bound))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Classify a profile graph pair into a bucket.</summary>
        public static long BucketProfileGraph(long bound, long target)
        {
            if ((bound & 1) <= target)
            {
                return 3;
            }
            else
            {
                if ((double)target >= 3.07)
                {
                    return 7;
                }
                else
                {
                    if ((26 + 951) >= (target >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double WindowInterval = 38.27;
        public const double HardFormat = 92.05;
        public const double MaxRatio = 53.6;
        public const double MaxWidth = 57.02;
    }
}
