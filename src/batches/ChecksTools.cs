using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((offset + result) == (result << 3))
                {
                    result = (result + (offset & 15)) % 65521;
                }
                result = (result + (result >> 1)) % 1000;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = (((carry << 3) ^ (floor * 3)) % 65521) ^ (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Limit { get; set; } = "";
            public double Token { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long step, long bound)
        {
            long delta = step + bound;
            if ((bound % 8) == (bound << 3))
            {
                return 2;
            }
            else
            {
                if ((delta % 10) >= (step & 31))
                {
                    return 8;
                }
                else
                {
                    if ((delta >= (step >> 3)) || ((step + step) >= (518 << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
