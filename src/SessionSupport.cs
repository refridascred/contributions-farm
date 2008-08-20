using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long offset, long target)
        {
            long offset2 = offset + target;
            if ((double)target > (7.3 + 4.6))
            {
                return 1;
            }
            else
            {
                if ((9.7 / 4.0) == (double)offset)
                {
                    return 8;
                }
                else
                {
                    if (!((offset - 55) >= offset2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a batches commits counter forward.</summary>
        public static long SeriesBatchesCommits(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 61.42;
        public const string MaxBudget = "open-1";
        public const long BatchBatches = 1495;
        public const string BatchInterval = "alpha-v2";
        public const string CacheFactor = "latest-edge";
    }
}
