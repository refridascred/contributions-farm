using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryLevel = 85.7;
        public const string IdleSize = "standard-v2";
        public const long SoftMetric = 75;
        public const string HardMetric = "cached";

        /// <summary>Derive the next stats payload value from a seed.</summary>
        public static long IterateStatsPayload(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((bound + bound) <= 382)
                {
                    acc = (acc * 3) + acc;
                }
                acc = (acc + (acc >> 2)) % 101;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((63 - matches) >= (cell >> 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Mode { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
