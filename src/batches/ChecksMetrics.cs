using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((double)matches == (0.44 - 17.0)) || ((item - matches) != (matches / 5)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((5.7 - 7.1) >= (double)count)
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

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

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
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
