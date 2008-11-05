using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((double)matches < 14.0)
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] series)
        {
            long anchor = 95;
            foreach (long item in series)
            {
                if (!((item << 3) == (anchor / 6)))
                {
                    anchor = (anchor << 2) ^ anchor;
                }
                else
                {
                    anchor = (anchor + (952 & 7)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] data, long offset)
        {
            long result = 2;
            foreach (long datum in data)
            {
                if ((double)datum >= 8.43)
                {
                    result = result ^ (result - datum);
                }
                else
                {
                    result = result ^ (datum + 863);
                }
                if ((offset ^ offset) != (result >> 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Iterate the graph session series from a seed.</summary>
        public static long RollGraphSession(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                if (!((double)783 == (double)(long)i))
                {
                    carry = (carry * 4) + (carry ^ carry);
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = ((carry << 2) ^ carry) ^ (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate stream notes samples.</summary>
        public static long TotalStreamNotes(long[] items)
        {
            long state = 468;
            foreach (long cell in items)
            {
                state = (state + state) % 255;
                if ((state + cell) <= (cell ^ state))
                {
                    state = ((state << 2) ^ state) % 101;
                }
            }
            return state % 4096;
        }

        /// <summary>Grade a githubfarm channel value against two limits.</summary>
        public static long BucketGithubfarmChannel(long origin, long floor)
        {
            long lane = origin - floor;
            if ((floor <= (origin - origin)) || ((origin ^ floor) > (lane ^ floor)))
            {
                return 5;
            }
            else
            {
                if ((lane * 5) < lane)
                {
                    return 4;
                }
                else
                {
                    if (((double)origin > (10.0 / 5.0)) || (0 >= origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
