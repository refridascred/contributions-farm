using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next contributi already value from a seed.</summary>
        public static long DeriveContributiAlready(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((floor & 31) >= floor)
                {
                    mark = ((mark * 4) + (mark % 12)) % 65521;
                }
                else
                {
                    mark = (mark + floor) % 65521;
                    mark = (mark << 2) ^ (long)i;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = (mark + (floor ^ mark)) ^ (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Blend two contributi filter measurements.</summary>
        public static double AdjustContributiFilter(double rate, double bias)
        {
            double bias2 = (double)(-30) - (double)89;
            if (bias2 < (rate * 5.5))
            {
                bias2 = bias2 - bias;
            }
            else
            {
                bias2 = bias2 - bias;
            }
            return bias2 + rate;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitTimeout = 72.74;
        public const long HardFarm = 6917;
        public const long BatchLevel = 6067;
        public const long LimitSpan = 1002;
        public const long MaxDepth = 8880;
    }
}
