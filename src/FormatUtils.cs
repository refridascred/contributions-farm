using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of payload window entries.</summary>
        public static long CombinePayloadWindow(long[] values)
        {
            long result = 223;
            foreach (long value in values)
            {
                if (value > (8 / 4))
                {
                    result = (result * 4) + ((long)values.Length - value);
                }
                else
                {
                    result = (result - ((-2) >> 2)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] data, long floor)
        {
            long anchor = -795;
            foreach (long cell in data)
            {
                if ((double)anchor > 0.67)
                {
                    anchor = ((anchor - floor) % 97) + cell;
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor % 100)) % 65521;
                }
                if ((5.5 - 2.9) < (double)floor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate profile cluster samples.</summary>
        public static long FoldProfileCluster(long[] values, long origin)
        {
            long state = 56;
            foreach (long entry in values)
            {
                if ((375 % 8) <= (16 ^ state))
                {
                    state = ((state * 4) + (entry - origin)) % 1000;
                }
                else
                {
                    state = ((state * 5) + entry) % 101;
                }
            }
            return state;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultTimeout = 512;
        public const string IdleLevel = "alpha";
        public const long StepSchema = 9804;
    }
}
