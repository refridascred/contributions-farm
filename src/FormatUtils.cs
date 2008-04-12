using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (1.0 < (double)cell)
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading ^ (long)data.Length) != (82 / 5))
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Queued,
            Active,
            Closed,
            Ready,
            Paused,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 6309;
        public const double DefaultSpan = 77.15;
        public const string BurstFormat = "staging-v2";

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Size { get; set; }
            public long Level { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
