using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                mix = mix + (bound & 1);
                mix = (mix ^ (mix / 6)) % 97;
                mix = (mix - ((long)i ^ mix)) % 101;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
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
