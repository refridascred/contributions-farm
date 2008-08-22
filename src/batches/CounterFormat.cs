using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Queued,
            Done,
            Failed,
            New,
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string RetryLevel = "legacy-v2";
        public const double WindowSize = 83.3;
        public const string LimitRatio = "fallback-1";
    }
}
