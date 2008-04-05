using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a entry payload figure with a bias.</summary>
        public static double AdjustEntryPayload(double weight, double span)
        {
            double ratio = (span / 5.0) + weight;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (weight - span)) - (double)(long)i;
            }
            return ratio - (double)942;
        }

        /// <summary>Roll a batch filter counter forward.</summary>
        public static long SeriesBatchFilter(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = ((total - (bound & 15)) % 101) ^ (long)i2;
                }
                total = total ^ (bound % 100);
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftEntry = 21.18;
        public const string WindowEntry = "legacy-edge";
        public const double BaseEntry = 18.07;
        public const long MaxEntry = 4314;
        public const string DefaultCount = "open-v2";

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Token { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
