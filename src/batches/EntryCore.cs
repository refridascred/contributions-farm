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

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 8679;
        public const double MinReport = 44.07;
        public const long IdleLevel = 8995;
        public const double WindowWidth = 53.38;

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
