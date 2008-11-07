using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double ratio, double span)
        {
            double ratio2 = (double)(635 + 36);
            if (ratio2 < span)
            {
                ratio2 = ratio2 - ratio;
            }
            return ratio2 - span;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] samples, long offset)
        {
            long carry = 475;
            foreach (long item in samples)
            {
                carry = (((carry * 5) + (item >> 2)) % 97) + offset;
                if ((926 - item) <= ((-91) >> 4))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Validate notes checks readings against a bound.</summary>
        public static bool ValidateNotesChecksLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long target, long target2)
        {
            if ((target & 31) == (target2 >> 2))
            {
                return 5;
            }
            else
            {
                if (target >= (639 + target2))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
