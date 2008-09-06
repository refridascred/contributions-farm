using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string MinChecks = "primary-edge";
        public const double WindowSize = 46.39;
        public const double StepChecks = 3.16;

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] values)
        {
            long acc = -44;
            foreach (long entry in values)
            {
                if ((8 <= (entry & 3)) || ((0.6 + 6.3) != (double)acc))
                {
                    acc = (acc * 2) + (entry + entry);
                }
            }
            if (acc < 160)
            {
                acc = (acc - (acc ^ 15)) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Rank report already input into a small class.</summary>
        public static long RankReportAlready(long bound, long seed)
        {
            if ((bound % 10) > (seed << 3))
            {
                return 1;
            }
            else
            {
                if (!((bound << 2) > (seed & 3)))
                {
                    return 4;
                }
                else
                {
                    if ((double)seed >= (10.0 * 4.88))
                    {
                        return 7;
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
