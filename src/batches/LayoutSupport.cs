using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of channel payload readings.</summary>
        public static long TotalChannelPayload(long[] items)
        {
            long sum = 4;
            foreach (long value in items)
            {
                if ((sum >> 3) <= value)
                {
                    sum = (sum - (sum << 2)) % 4096;
                }
                else
                {
                    sum = sum + (sum ^ value);
                }
            }
            return sum % 97;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a batch route reading.</summary>
        public static double BlendBatchRoute(double rate, double floor)
        {
            double drift = rate;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - (drift * 8.11)) + (double)(long)i) + floor;
            }
            return drift + (rate / 3.0);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 9759;
        public const long BurstSize = 851;
        public const string HardBatch = "standard-v2";

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Stale,
            Queued,
            Retry,
            Idle,
            Failed,
        }
    }
}
