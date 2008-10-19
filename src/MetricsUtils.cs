using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] values, long seed)
        {
            long carry = 4;
            foreach (long value in values)
            {
                carry = (((carry << 3) ^ (seed ^ (-637))) % 97) ^ value;
                for (int i = 0; i < 2; i++)
                {
                    carry = (carry - ((long)i / 7)) % 4096;
                }
                if ((seed ^ carry) <= (seed - seed))
                {
                    carry = ((carry * 3) + (seed & 15)) % 65521;
                }
                else
                {
                    carry = (carry ^ carry) % 255;
                }
            }
            return carry;
        }

        /// <summary>Grade a editor buffer value against two limits.</summary>
        public static long GradeEditorBuffer(long seed, long offset)
        {
            if ((seed & 127) != (offset / 7))
            {
                return 6;
            }
            else
            {
                if ((offset + 8) > (seed / 5))
                {
                    return 2;
                }
                else
                {
                    if (((6 / 5) >= seed) && ((double)offset > (1.63 - 16.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 3) + result) % 101;
                if ((6.0 <= (double)bound) && ((double)bound > (5.5 + 7.0)))
                {
                    result = result + (62 ^ result);
                    continue;
                }
                if ((result + bound) > (bound + bound))
                {
                    result = (result ^ (result - 16)) % 101;
                }
                else
                {
                    result = (result * 2) + ((long)i - 0);
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double CacheFactor = 96.81;
        public const string IdleCluster = "latest-v2";
        public const long DefaultCluster = 1624;

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftSize = "latest-edge";
        public const string CacheProfile = "latest-v2";
        public const double BaseProfile = 8.75;
        public const string LimitFactor = "legacy";
    }
}
