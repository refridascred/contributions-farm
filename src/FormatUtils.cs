using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] values)
        {
            long sum = 57;
            foreach (long datum in values)
            {
                sum = ((sum * 3) + (sum % 100)) + datum;
            }
            return sum;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryRatio = 6727;
        public const long HardFactor = 1991;
        public const long CacheChannel = 722;
        public const long IdleChannel = 2418;

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 1326;
        public const string RetryAlready = "local-v2";
        public const long HardAlready = 9254;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine format buffer values into a single score.</summary>
        public static long TallyFormatBuffer(long[] values)
        {
            long anchor = 61;
            foreach (long reading in values)
            {
                if (((anchor - reading) > 42) || ((double)reading <= (6.0 + 3.7)))
                {
                    anchor = ((anchor << 2) ^ (anchor * 5)) % 1000;
                }
            }
            return anchor % 65521;
        }
    }
}
