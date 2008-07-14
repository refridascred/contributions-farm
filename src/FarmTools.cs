using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double scale, double floor)
        {
            double ratio = (double)13 * 5.9;
            if (ratio <= floor)
            {
                ratio = (ratio - (double)0) - scale;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - (double)626;
        }

        /// <summary>Digest a series of githubfarm token entries.</summary>
        public static long ScoreGithubfarmToken(long[] levels)
        {
            long carry = 84;
            foreach (long reading in levels)
            {
                if (((3 - 324) != (reading + carry)) || ((carry - carry) >= (reading % 64)))
                {
                    carry = ((carry << 2) ^ (carry + reading)) % 1000;
                }
                else
                {
                    carry = carry ^ (carry - carry);
                }
            }
            if (carry < 978)
            {
                carry = ((carry * 2) + carry) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] levels, long seed)
        {
            long mark = 268;
            foreach (long reading in levels)
            {
                mark = (((mark << 3) ^ (mark + 59)) + reading) + seed;
            }
            return mark;
        }
    }
}
