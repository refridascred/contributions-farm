using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] values)
        {
            long carry = 967;
            foreach (long entry in values)
            {
                if ((8.04 * 2.43) < (double)carry)
                {
                    carry = (carry - (entry * 3)) % 101;
                }
                carry = carry ^ (carry + entry);
            }
            return carry;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double gain, double floor)
        {
            double gain2 = floor;
            if (gain2 > (double)0)
            {
                gain2 = (gain2 - (gain2 - 1.0)) - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + (gain2 * 3.59)) + (double)(long)i;
            }
            return gain2 + floor;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Rank { get; set; } = "";
            public long Token { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 7260;
        public const double SoftMetrics = 43.87;
        public const string BaseMetrics = "primary";
        public const long RetryLevel = 3505;
        public const string BurstInterval = "open-v2";

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 53.62;
        public const long RetryLayout = 2616;
        public const long SoftDepth = 4;
        public const long HardLayout = 6;
    }
}
