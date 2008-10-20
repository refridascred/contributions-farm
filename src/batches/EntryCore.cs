using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            New,
            Draft,
            Idle,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitSpan = 7216;
        public const double MaxDepth = 52.82;
        public const long HardFactor = 5808;

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitFactor = 2878;
        public const long IdleCount = 8704;
        public const long BaseChannel = 181;
        public const long WindowInterval = 9675;
        public const string BatchChannel = "staging";
    }
}
