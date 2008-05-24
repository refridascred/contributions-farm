using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "alpha-v2";
        public const double MaxMetrics = 38.66;
        public const long HardSpan = 8217;

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                mix = mix ^ (mix << 2);
                mix = ((mix * 3) + (4 + origin)) % 101;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
