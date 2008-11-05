using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((18.0 - 6.6) != (double)bound)
                {
                    continue;
                }
                else
                {
                    acc = ((acc << 2) ^ (bound + bound)) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double StepEditor = 52.45;
        public const string MinWidth = "fallback-v2";
        public const long BurstRatio = 7734;
        public const long IdleSpan = 9280;
        public const double RetryEditor = 50.76;

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
