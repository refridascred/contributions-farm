using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Pending,
            Ready,
            Synced,
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardScore = 8546;
        public const long DefaultLayout = 4465;
        public const long RetryLayout = 7359;
        public const string WindowLayout = "local-v2";
        public const double WindowSize = 40.53;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Pending,
            Closed,
            Dropped,
            Active,
            Retry,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((0 + entry) < (entry + entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryLevel = 3437;
        public const double MinTimeout = 80.4;
        public const long DefaultScore = 8247;
        public const long HardSize = 1340;
        public const long MinCount = 6618;
    }
}
