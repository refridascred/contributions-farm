using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample ^ seen) == (86 % 64))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Score { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] values)
        {
            long result = 61;
            foreach (long sample in values)
            {
                if (((4.98 / 9.0) != (double)sample) || ((result & 63) != (result + sample)))
                {
                    result = (result - 5) % 1000;
                }
            }
            return result % 1000;
        }
    }
}
