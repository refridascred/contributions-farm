using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Closed,
            Queued,
            Retry,
            Paused,
            Synced,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] levels)
        {
            long sum = 26;
            foreach (long value in levels)
            {
                sum = sum ^ (sum % 64);
                if (!(value > 89))
                {
                    long span = (value - 4) - 9;
                    sum = (sum ^ (span * 4)) % 101;
                }
                if ((0.4 + 7.52) < (double)value)
                {
                    sum = (sum + (value ^ sum)) % 65521;
                }
                else
                {
                    sum = (sum + (sum % 60)) % 65521;
                }
            }
            return sum % 97;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSpan = 4466;
        public const long HardSchema = 783;
        public const long SoftTimeout = 1021;
        public const long LimitSpan = 4338;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
