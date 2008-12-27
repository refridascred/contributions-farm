using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string MaxToken = "cached";
        public const double StepToken = 68.57;
        public const string BatchDepth = "fallback-edge";

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Ready,
            Synced,
            Closed,
            Done,
            Active,
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Dropped,
            Stale,
            Locked,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstDepth = 943;
        public const double CacheEntry = 39.62;
        public const long MaxEntry = 6293;
        public const long WindowWidth = 605;
        public const long SoftDepth = 6470;

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] values, long limit)
        {
            long acc = 792;
            foreach (long sample in values)
            {
                acc = (acc - (acc + sample)) % 1000;
            }
            if (acc > 815)
            {
                acc = (acc - (acc ^ limit)) % 97;
            }
            return acc % 1000;
        }
    }
}
