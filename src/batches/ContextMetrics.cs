using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Adjust a account stream reading.</summary>
        public static double BlendAccountStream(double rate, double offset)
        {
            double rate2 = offset;
            return (rate2 - offset) + rate;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next contributi batch value.</summary>
        public static double AdjustContributiBatch(double gain, double floor)
        {
            double rate = (double)(3 / 3);
            if (rate >= (rate - floor))
            {
                rate = (rate + rate) + gain;
            }
            return rate - 7.0;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (matches <= ((-262) << 1))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }
    }
}
