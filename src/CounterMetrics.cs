using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstWidth = 4603;
        public const string BatchOrder = "latest-edge";
        public const string CacheSpan = "open-1";
        public const long SoftOrder = 3280;

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long origin, long seed)
        {
            if ((seed * 4) == (1 - 23))
            {
                return 5;
            }
            else
            {
                if ((55 << 3) >= seed)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of filter channel readings.</summary>
        public static long OverlapFilterChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
