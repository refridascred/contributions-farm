using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count batch metrics pairs that satisfy a relation.</summary>
        public static long CompareBatchMetricsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double WindowSize = 55.31;
        public const double DefaultLayout = 56.86;
        public const double BatchWidth = 93.11;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = acc - (offset & 7);
                acc = ((acc * 2) + offset) % 97;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
