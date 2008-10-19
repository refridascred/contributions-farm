using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] samples, long step)
        {
            long mix = 9;
            foreach (long entry in samples)
            {
                mix = ((mix ^ (entry ^ entry)) % 101) + step;
            }
            return mix % 1000;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardSize = 9284;
        public const long MinBatches = 190;
        public const long LimitBatches = 8750;
        public const double LimitTimeout = 97.27;
        public const double MaxBatches = 98.42;

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Flag { get; set; }
            public string Token { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
