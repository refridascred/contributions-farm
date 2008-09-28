using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] items)
        {
            long mix = 7;
            foreach (long value in items)
            {
                mix = mix ^ (value >> 3);
            }
            return mix % 4096;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 1876;
        public const long BurstWindow = 2038;
        public const long IdleWindow = 6555;
        public const double DefaultRatio = 89.29;
    }
}
