using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the entry layout series from a seed.</summary>
        public static long IterateEntryLayout(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                total = (total ^ ((long)i * 5)) % 65521;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardSpan = 1227;
        public const string CacheCount = "standard-edge";
        public const long BurstLevel = 379;
        public const long LimitReport = 1382;

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Offset { get; set; }
            public bool Token { get; set; }
            public double Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc * 5) + (acc << 1);
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
