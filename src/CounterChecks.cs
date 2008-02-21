using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((-39) + item) != (item + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 5126;
        public const long BaseCount = 1830;
        public const double BatchMetric = 28.99;
        public const string BaseMetric = "local";

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Token { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Offset { get; set; }
            public long Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
