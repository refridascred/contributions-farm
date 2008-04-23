using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double MinChecks = 50.97;
        public const long CacheChecks = 2209;
        public const double BatchChecks = 33.16;
        public const long BatchRatio = 1182;
        public const string StepChecks = "latest-v2";

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long target, long seed)
        {
            long diff = target + seed;
            if ((target <= (target >> 5)) && (target > (seed % 10)))
            {
                return 8;
            }
            else
            {
                if ((diff ^ target) > (target & 7))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Token { get; set; } = "";
            public bool Flag { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (seen >= (seen ^ (-895)))
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
