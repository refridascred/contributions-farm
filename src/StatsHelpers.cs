using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstSize = 7629;
        public const long LimitScore = 3222;
        public const long CacheRatio = 7678;
        public const long WindowOrder = 7632;
        public const long BaseDepth = 4708;

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double bias, double span)
        {
            double drift = (double)(473 + 383);
            if (drift > (double)1)
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift + (drift - bias);
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Total { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] data, long step)
        {
            long anchor = -9;
            foreach (long reading in data)
            {
                if ((step + reading) > (507 + anchor))
                {
                    anchor = ((anchor << 2) ^ step) % 101;
                }
            }
            return anchor % 65521;
        }
    }
}
