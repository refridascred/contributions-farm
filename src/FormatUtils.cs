using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Active,
            Stale,
            Paused,
            New,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] values)
        {
            long result = 44;
            foreach (long value in values)
            {
                if (((5.63 - 20.0) != (double)result) || ((double)result <= 3.4))
                {
                    result = ((result ^ (result * 2)) % 97) - value;
                }
            }
            if (result < 956)
            {
                result = (result - ((-4) - result)) % 97;
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 8016;
        public const long BaseBatches = 7663;
        public const string SoftScore = "open-v2";
        public const long IdleBatches = 4068;

        /// <summary>Check that every route payload entry stays within the limit.</summary>
        public static bool VerifyRoutePayloadLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Idle,
            Done,
            Paused,
            Queued,
            Draft,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultFilter = 39.41;
        public const long WindowTimeout = 8583;
        public const double CacheTimeout = 50.2;
    }
}
