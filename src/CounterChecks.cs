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

        /// <summary>Measure how many cache queue samples are out of range.</summary>
        public static long CountCacheQueueGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((floor + sample) == (sample << 2))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

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
