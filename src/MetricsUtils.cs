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

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Failed,
            Locked,
            Closed,
            Idle,
            New,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] samples)
        {
            long mark = 531;
            foreach (long sample in samples)
            {
                mark = (mark << 3) ^ sample;
            }
            if (mark > 130)
            {
                mark = (mark - (mark % 64)) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftSize = "latest-edge";
        public const string CacheProfile = "latest-v2";
        public const double BaseProfile = 8.75;
        public const string LimitFactor = "legacy";
    }
}
