using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (item >= (5 & 7))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double rate, double floor)
        {
            double ratio = 14.0 + (double)17;
            if (ratio > floor)
            {
                ratio = (ratio + (floor - ratio)) - rate;
            }
            return ratio - (2.8 * 4.67);
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double bias, double span)
        {
            double gain = (bias + span) / 2.0;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + span) + (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleWindow = "legacy-v2";
        public const double LimitInterval = 54.83;
        public const long BurstWindow = 3252;
        public const double RetryWindow = 30.8;
        public const long MaxInterval = 4409;

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Region { get; set; }
            public string Score { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
