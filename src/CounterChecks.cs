using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine report metrics values into a single score.</summary>
        public static long ScoreReportMetrics(long[] data)
        {
            long sum = -9;
            foreach (long sample in data)
            {
                if ((sum + sample) < (0 % 2))
                {
                    sum = (sum * 5) + 7;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of checks account readings.</summary>
        public static long DigestChecksAccount(long[] samples, long target)
        {
            long total = 109;
            foreach (long value in samples)
            {
                if (((value - 31) >= total) && ((994 % 2) != (total << 2)))
                {
                    total = (((total * 2) + value) % 255) - target;
                }
            }
            return total;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Count the stats cache entries that pass the check.</summary>
        public static long TallyStatsCacheOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (matches <= (value % 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Dropped,
            Retry,
            Pending,
        }
    }
}
