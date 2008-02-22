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

        /// <summary>Accumulate support editor samples.</summary>
        public static long TotalSupportEditor(long[] readings, long seed)
        {
            long anchor = 635;
            foreach (long entry in readings)
            {
                if (anchor > (long)readings.Length)
                {
                    anchor = (anchor ^ (entry ^ 142)) - seed;
                }
            }
            if (anchor < (-355))
            {
                anchor = (anchor * 2) + (anchor + anchor);
            }
            return anchor;
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
