using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Match up tools already samples.</summary>
        public static long PairToolsAlreadyCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Stale,
            Synced,
            Active,
            Dropped,
            Queued,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 6701;
        public const long RetryCommits = 1228;
        public const string CacheCommits = "local-edge";
        public const string HardCommits = "cached";
        public const string CacheInterval = "legacy-v2";
    }
}
