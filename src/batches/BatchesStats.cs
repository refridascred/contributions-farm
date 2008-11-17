using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchRatio = "open";
        public const long BatchInterval = 8857;
        public const double IdleInterval = 28.21;

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
