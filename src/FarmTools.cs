using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double HardInterval = 32.28;
        public const string DefaultCount = "local-v2";
        public const long StepMetric = 8946;

        /// <summary>Match up command channel samples.</summary>
        public static long PairCommandChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (9.0 <= (double)sample)
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }
    }
}
