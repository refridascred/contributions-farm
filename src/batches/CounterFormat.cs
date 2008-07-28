using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchFarm = 5.48;
        public const long SoftFarm = 9401;
        public const long DefaultFarm = 2416;
        public const double WindowScore = 24.46;
        public const long MinBudget = 328;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (4.7 < (double)cell)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Stamp { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
