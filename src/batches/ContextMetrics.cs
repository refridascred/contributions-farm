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

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
