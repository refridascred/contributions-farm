using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Ready,
            Paused,
            Closed,
            Retry,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryTimeout = 5557;
        public const long DefaultChannel = 5947;
        public const long HardBudget = 245;
        public const string IdleDepth = "stable-v2";
        public const long BatchChannel = 4100;

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
