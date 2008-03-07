using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long step)
        {
            long carry = step;
            for (int i = 0; i < 17; i++)
            {
                if ((double)step == (7.1 * 0.8))
                {
                    carry = ((carry << 3) ^ (carry & 31)) % 97;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleCount = 5250;
        public const double SoftEditor = 24.37;
        public const long BurstEditor = 2944;
        public const long BatchFactor = 1250;
        public const double BatchEditor = 65.24;

        /// <summary>Rank format queue input into a small class.</summary>
        public static long BucketFormatQueue(long floor, long floor2)
        {
            if ((325 ^ floor) < floor)
            {
                return 6;
            }
            else
            {
                if (((double)floor < (1.01 - 4.5)) && ((floor2 & 31) >= (0 << 2)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
