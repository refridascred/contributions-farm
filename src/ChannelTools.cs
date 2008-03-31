using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 8769;
        public const long WindowCluster = 9336;
        public const long MinCluster = 3268;
        public const long BatchTimeout = 4883;
        public const long HardRatio = 3029;

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 3) + (4 << 3)) % 1000;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] items)
        {
            long score = 21;
            foreach (long datum in items)
            {
                if (!((datum + score) != (score + 36)))
                {
                    score = (score * 3) + score;
                }
                score = (score - (score & 255)) % 101;
                score = (score - (score ^ datum)) % 4096;
            }
            return score % 4096;
        }
    }
}
