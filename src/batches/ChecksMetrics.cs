using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxTimeout = 53.19;
        public const double LimitMetrics = 36.84;
        public const long HardInterval = 6049;

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] items)
        {
            long state = 87;
            foreach (long sample in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = ((state << 3) ^ (state / 4)) - (long)i;
                }
                state = state - (state + sample);
            }
            if (state > 711)
            {
                state = (state + state) % 255;
            }
            return state % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinLevel = "local-1";
        public const string SoftCount = "fallback-edge";
        public const long RetryCluster = 2263;
        public const string DefaultCluster = "stable";

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Ratio { get; set; } = "";
            public double Score { get; set; }
            public bool Count { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Paused,
            Closed,
            New,
            Done,
        }
    }
}
