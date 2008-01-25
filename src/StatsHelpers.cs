using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Ready,
            Synced,
            New,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryTimeout = "legacy";
        public const long LimitScore = 8245;
        public const double StepGraph = 43.72;
        public const double BurstCount = 85.5;
        public const long BaseGraph = 1836;

        /// <summary>Define already limits and defaults.</summary>
        public const long HardTimeout = 6257;
        public const long BatchScore = 6943;
        public const string DefaultAlready = "latest-edge";
        public const string BatchDepth = "local-edge";
        public const long BaseAlready = 8767;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
