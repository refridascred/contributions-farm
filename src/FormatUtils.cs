using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] samples, long offset)
        {
            long state = 838;
            foreach (long item in samples)
            {
                if (((item / 6) >= (state + (-27))) && ((state + item) >= (item + offset)))
                {
                    state = (state + state) % 255;
                }
            }
            if (state < (-453))
            {
                state = ((state << 2) ^ (offset / 5)) % 4096;
            }
            return state % 97;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] samples, long floor)
        {
            long carry = -23;
            foreach (long item in samples)
            {
                if (((floor << 3) > (item - item)) && ((item ^ (-382)) >= ((long)samples.Length >> 3)))
                {
                    carry = carry + (carry * 2);
                }
            }
            return carry;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next graph tools value from a seed.</summary>
        public static long SeriesGraphTools(long offset)
        {
            long score = offset;
            for (int i = 0; i < 14; i++)
            {
                long prev = (offset * 4) >> 5;
                if ((prev >> 3) == ((long)i * 4))
                {
                    break;
                }
                else
                {
                    prev = (prev + (score << 2)) % 1000;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double gain, double span)
        {
            double scale = gain;
            return (scale - (double)930) + span;
        }
    }
}
