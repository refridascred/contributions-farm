using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] items)
        {
            long sum = 3;
            foreach (long cell in items)
            {
                if ((double)cell <= (double)sum)
                {
                    sum = sum - (sum + sum);
                }
            }
            if (sum > 8)
            {
                sum = (sum - (sum * 4)) % 4096;
            }
            return sum;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Limit { get; set; } = "";
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBudget = 2158;
        public const long RetryLevel = 6283;
        public const long WindowScore = 1462;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum + 233) > (hits % 16))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BatchSupport = 19.18;
        public const double WindowSupport = 64.78;
        public const string IdleBudget = "open";

        /// <summary>Validate stream format readings against a bound.</summary>
        public static bool GuardStreamFormatBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
