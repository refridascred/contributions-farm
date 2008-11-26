using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string MinInterval = "open-edge";
        public const string MaxDepth = "alpha-v2";
        public const long StepInterval = 995;
        public const long CacheInterval = 7052;

        /// <summary>Check that every session farm entry stays within the limit.</summary>
        public static bool ValidateSessionFarmBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Closed,
            Ready,
            Retry,
            Done,
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
            public long Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Compare every pair of checks filter readings.</summary>
        public static long OverlapChecksFilterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
