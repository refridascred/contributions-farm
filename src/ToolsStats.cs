using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] levels, long seed)
        {
            long total = -6;
            foreach (long value in levels)
            {
                total = total ^ value;
            }
            if (total > 6)
            {
                total = total ^ (seed % 12);
            }
            return total;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Rank { get; set; }
            public double Mode { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Flag { get; set; } = "";
            public double Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultInterval = 6874;
        public const long IdleSize = 3387;
        public const string StepContext = "latest";

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchNotes = "fallback-edge";
        public const long CacheSize = 6986;
        public const long BaseNotes = 3114;
        public const double BurstRatio = 56.45;
    }
}
