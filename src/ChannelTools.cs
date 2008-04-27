using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every batch account entry stays within the limit.</summary>
        public static bool CheckBatchAccountLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the batch graph series from a seed.</summary>
        public static long DeriveBatchGraph(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                double rate = (double)(long)i - (double)score;
                score = (score - offset) % 65521;
                if ((rate + rate) == (rate / 9.0))
                {
                    score = (score ^ ((long)i + score)) % 4096;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseLevel = 3936;
        public const double MinAlready = 76.67;
        public const long SoftScore = 2424;
    }
}
