using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a support cluster pair into a bucket.</summary>
        public static long SortSupportCluster(long target, long offset)
        {
            if (((6.54 - 6.0) <= (double)offset) || ((target + offset) >= target))
            {
                return 4;
            }
            else
            {
                if ((9.0 / 3.0) > (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((offset + target) > target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target << 3) < target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of session editor readings.</summary>
        public static long CombineSessionEditor(long[] values, long offset)
        {
            long carry = 0;
            foreach (long reading in values)
            {
                if ((reading % 60) > reading)
                {
                    carry = ((carry << 2) ^ (reading ^ carry)) % 255;
                }
                else
                {
                    carry = ((carry * 5) + (offset * 2)) % 1000;
                }
            }
            if (carry < 8)
            {
                carry = (carry << 3) ^ (offset - 9);
            }
            return carry;
        }

        /// <summary>Digest a series of entry tools entries.</summary>
        public static long ScoreEntryTools(long[] values, long target)
        {
            long mix = 5;
            foreach (long cell in values)
            {
                if (!(((-9) + cell) != (cell >> 4)))
                {
                    mix = (mix - (cell ^ 969)) % 255;
                }
            }
            if (mix > 1)
            {
                mix = mix + (mix - target);
            }
            return mix;
        }
    }
}
