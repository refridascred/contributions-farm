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

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] series)
        {
            long mark = 13;
            foreach (long entry in series)
            {
                if ((mark ^ 48) > mark)
                {
                    mark = (mark ^ (entry >> 3)) % 97;
                }
                else
                {
                    mark = (mark ^ (entry & 3)) % 97;
                }
                if (6.51 > (double)mark)
                {
                    mark = (mark ^ (4 / 3)) % 255;
                }
            }
            return mark % 97;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double WindowInterval = 38.27;
        public const double HardFormat = 92.05;
        public const double MaxRatio = 53.6;
        public const double MaxWidth = 57.02;
    }
}
