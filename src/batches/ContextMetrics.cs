using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Level { get; set; }
            public double Token { get; set; }
            public string Mode { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long bound, long limit)
        {
            if (((limit % 60) <= (limit - bound)) && (limit >= (bound >> 2)))
            {
                return 2;
            }
            else
            {
                if ((double)bound <= (5.6 * 1.31))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxLevel = "fallback-edge";
        public const long RetryNotes = 5674;
        public const long LimitNotes = 8890;
        public const long SoftNotes = 6326;
        public const double LimitFactor = 78.1;

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((long)readings.Length < (matches + item)) || ((item % 2) >= (matches / 3)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
