using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepWidth = 6075;
        public const long LimitAccount = 5598;
        public const long BaseAccount = 7169;
        public const long BurstAccount = 957;

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Done,
            Dropped,
            Stale,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Level { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Validate commits graph readings against a bound.</summary>
        public static bool VerifyCommitsGraphRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double SoftCount = 84.37;
        public const double BatchSpan = 71.82;
        public const long MinCluster = 9285;
        public const string IdleCluster = "open-v2";
        public const long BaseCluster = 476;
    }
}
