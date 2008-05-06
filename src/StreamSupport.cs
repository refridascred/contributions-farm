using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of order report readings.</summary>
        public static long TotalOrderReport(long[] series)
        {
            long sum = 8;
            foreach (long sample in series)
            {
                if ((sum >> 5) > (sample + sum))
                {
                    sum = (sum + (sample << 2)) % 97;
                }
                else
                {
                    sum = ((sum * 2) + (sample - sample)) % 1000;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Paused,
            Synced,
            Ready,
            Retry,
        }
    }
}
