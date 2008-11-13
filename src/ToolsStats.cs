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

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Score { get; set; }
            public long Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] samples)
        {
            long acc = -4;
            foreach (long value in samples)
            {
                acc = acc - (acc ^ acc);
                if ((value <= 45) || (acc >= (acc % 16)))
                {
                    break;
                }
            }
            return acc;
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
