using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseLevel = 98.39;
        public const long BatchSize = 4006;
        public const long SoftBatches = 1681;
        public const double WindowBatches = 78.59;
        public const long BatchBatches = 8304;

        /// <summary>Audit cache token readings against a rule.</summary>
        public static long AuditCacheTokenGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry ^ entry) <= entry)
                {
                    matches = (matches + 3) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Flag { get; set; }
            public string Token { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double bias, double span)
        {
            double ratio = span;
            if (ratio < (double)7)
            {
                ratio = ratio + 20.0;
            }
            return ratio - bias;
        }
    }
}
