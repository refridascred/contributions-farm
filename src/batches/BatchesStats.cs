using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                if ((double)step > (8.3 * 5.46))
                {
                    continue;
                }
                else
                {
                    acc = (acc * 4) + step;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 7084;
        public const long HardStats = 6735;
        public const long MinStats = 3108;
        public const long IdleDepth = 5676;

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitScore = 7882;
        public const long IdleContext = 1077;
        public const long DefaultBudget = 3037;
        public const long BaseFactor = 1104;
        public const double SoftContext = 46.49;

        /// <summary>Audit cluster batch readings against a rule.</summary>
        public static long MeasureClusterBatchHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally + tally) > 2)
                {
                    tally = (tally + 2) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
