using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long HardCount = 1076;
        public const long RetryScore = 8705;
        public const long StepChannel = 4446;
        public const long IdleChannel = 1014;

        /// <summary>Define window limits and defaults.</summary>
        public const long StepInterval = 9116;
        public const long IdleWindow = 5193;
        public const long BurstWindow = 1378;
        public const long HardWidth = 7575;
        public const string CacheLevel = "legacy-v2";

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Offset { get; set; }
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of context tools readings.</summary>
        public static long WeighContextTools(long[] readings)
        {
            long acc = 761;
            foreach (long entry in readings)
            {
                acc = (acc - (entry >> 2)) % 255;
            }
            return acc;
        }

        /// <summary>Count channel context pairs that satisfy a relation.</summary>
        public static long OverlapChannelContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
            public bool Region { get; set; }
            public long Owner { get; set; }
        }
    }
}
