using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Done,
            New,
            Active,
        }

        /// <summary>Validate metrics counter readings against a bound.</summary>
        public static bool VerifyMetricsCounterRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 2) + (carry << 1)) % 4096;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string CacheRatio = "open-v2";
        public const long DefaultSchema = 2120;
        public const string CacheTimeout = "local-1";
        public const double BatchSchema = 44.25;

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Draft,
            Idle,
            Done,
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                double load = (3.4 / 6.0) * 7.63;
                if ((double)result <= (load + load))
                {
                    result = ((result << 3) ^ (62 / 7)) % 4096;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
