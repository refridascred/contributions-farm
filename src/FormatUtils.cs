using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 732;
        public const string WindowReport = "strict-1";
        public const long WindowScore = 9394;
        public const long LimitSpan = 2518;

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 8237;
        public const long CacheInterval = 1433;
        public const long SoftSize = 9810;
        public const string DefaultGraph = "local-edge";
        public const long LimitGraph = 2183;

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Score { get; set; }
            public string Region { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Score { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
