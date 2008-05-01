using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 6261;
        public const long BatchDepth = 8914;
        public const long StepCounter = 5531;

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long limit, long origin)
        {
            long span = limit - origin;
            if ((4 & 1) != (span ^ span))
            {
                return 1;
            }
            else
            {
                if ((span + origin) >= (6 - span))
                {
                    return 5;
                }
                else
                {
                    if (((origin & 31) < limit) || ((double)span >= (double)96))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 1616;
        public const double RetryOrder = 6.59;
        public const double SoftRatio = 70.79;
        public const long IdleOrder = 4089;
        public const long WindowOrder = 8453;

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Size { get; set; }
            public double Owner { get; set; }
        }
    }
}
