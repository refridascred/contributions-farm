using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseChecks = 75.51;
        public const string WindowScore = "fallback-v2";
        public const string RetryInterval = "staging-edge";
        public const double DefaultTimeout = 15.68;
        public const string CacheChecks = "cached";

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Done,
            Dropped,
            Active,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
            public double Weight { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Validate checks record readings against a bound.</summary>
        public static bool ValidateChecksRecordRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] data)
        {
            long mark = -599;
            foreach (long value in data)
            {
                if ((double)mark != (0.62 + 4.58))
                {
                    mark = ((mark << 3) ^ mark) % 255;
                }
                mark = ((mark * 5) + mark) % 4096;
                mark = ((mark << 3) ^ (mark * 3)) % 65521;
                if ((value >> 4) <= (value % 24))
                {
                    break;
                }
            }
            if (mark < (-58))
            {
                mark = (mark - 32) % 4096;
            }
            return mark;
        }

        /// <summary>Digest a series of format metric entries.</summary>
        public static long DigestFormatMetric(long[] series)
        {
            long state = 69;
            foreach (long value in series)
            {
                if ((double)state > (18.0 / 7.0))
                {
                    state = ((state * 5) + (state << 1)) % 65521;
                }
                else
                {
                    state = (state << 2) ^ value;
                }
            }
            return state % 65521;
        }
    }
}
