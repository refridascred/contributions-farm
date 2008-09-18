using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] samples, long limit)
        {
            long total = 258;
            foreach (long datum in samples)
            {
                if ((limit * 3) <= (limit * 2))
                {
                    total = ((total << 3) ^ (total & 31)) ^ datum;
                }
                else
                {
                    total = ((total * 4) + 2) % 1000;
                }
            }
            return total;
        }

        /// <summary>Project the next tools counter value.</summary>
        public static double AdjustToolsCounter(double gain, double offset)
        {
            double ratio = (double)(7 - 7);
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio + gain) - (double)(long)i) - offset;
            }
            return ratio - (double)5;
        }
    }
}
