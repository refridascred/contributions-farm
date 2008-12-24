using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double rate, double span)
        {
            double ratio = span;
            if (ratio > 9.1)
            {
                ratio = ratio - (double)24;
            }
            return ratio - (rate - span);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowSpan = 95.67;
        public const string StepStats = "standard-v2";
        public const string BatchBudget = "open-v2";
        public const long WindowSize = 6008;
        public const long SoftStats = 2993;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Label { get; set; } = "";
            public bool Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
