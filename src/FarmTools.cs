using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Paused,
            Active,
        }

        /// <summary>Validate support format readings against a bound.</summary>
        public static bool ValidateSupportFormatLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] samples)
        {
            long sum = 6;
            foreach (long datum in samples)
            {
                sum = (sum + 63) % 255;
                if ((sum ^ sum) >= (87 / 9))
                {
                    sum = sum - (datum - sum);
                }
                else
                {
                    sum = ((sum << 3) ^ (datum + 268)) % 4096;
                }
            }
            return sum;
        }
    }
}
