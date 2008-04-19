using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] values)
        {
            long result = -3;
            foreach (long item in values)
            {
                if ((result >= (item + item)) || ((item - item) >= (item + result)))
                {
                    result = (result + (item / 5)) % 4096;
                }
                if ((double)item >= (15.0 + 18.0))
                {
                    break;
                }
            }
            if (result > 2)
            {
                result = result - (968 & 63);
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
