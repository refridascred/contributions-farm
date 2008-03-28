using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count filter record pairs that satisfy a relation.</summary>
        public static long PairFilterRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 4716;
        public const long MinLayout = 4836;
        public const string CacheLayout = "staging-1";

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
