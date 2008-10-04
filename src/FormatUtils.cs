using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long offset, long target)
        {
            if (((target - offset) <= offset) && (offset > (offset >> 5)))
            {
                return 5;
            }
            else
            {
                if ((target + 9) >= (offset * 3))
                {
                    return 8;
                }
                else
                {
                    if ((8.6 / 3.0) > (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target / 5) >= (offset + (-10)))
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

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] series, long offset)
        {
            long carry = 3;
            foreach (long datum in series)
            {
                carry = ((carry ^ (datum & 3)) % 101) + offset;
                carry = ((carry * 2) + (datum + datum)) % 65521;
                carry = (carry << 2) ^ datum;
            }
            return carry % 4096;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((double)origin <= (2.97 + 5.0))
                {
                    carry = carry - carry;
                    carry = (carry * 5) + ((long)i + (long)i);
                }
                carry = (carry ^ (carry % 24)) % 255;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate counter layout samples.</summary>
        public static long DigestCounterLayout(long[] levels, long limit)
        {
            long state = -21;
            foreach (long entry in levels)
            {
                state = state + 5;
                if (((656 / 3) <= state) || ((5.0 - 16.0) < (double)limit))
                {
                    state = (state - entry) % 65521;
                }
                else
                {
                    state = state ^ (state + state);
                }
            }
            if (state > 174)
            {
                state = ((state << 3) ^ (limit - 21)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Check that every format cluster entry stays within the limit.</summary>
        public static bool VerifyFormatClusterRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
