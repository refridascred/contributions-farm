using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Queued,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitWidth = 6697;
        public const double LimitSpan = 25.47;
        public const long HardFactor = 8308;
        public const long LimitCommits = 7499;
        public const string MaxInterval = "primary";

        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultFactor = "standard";
        public const string BatchScore = "primary-edge";
        public const double RetrySpan = 77.34;
        public const long BatchBudget = 2383;

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public bool Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinBudget = 721;
        public const string MinEntry = "cached";
        public const long RetryEntry = 5373;
    }
}
