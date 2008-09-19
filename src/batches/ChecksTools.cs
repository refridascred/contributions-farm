using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Pending,
            Ready,
            Closed,
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] readings)
        {
            long sum = 60;
            foreach (long entry in readings)
            {
                if ((9.22 * 6.3) > (double)sum)
                {
                    sum = ((sum * 3) + (sum * 4)) % 65521;
                }
                else
                {
                    sum = (sum + (sum - entry)) % 97;
                }
            }
            if (sum > 172)
            {
                sum = (sum ^ (707 % 16)) % 65521;
            }
            return sum;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double scale, double floor)
        {
            double ratio = (double)(658 ^ 999);
            if (ratio <= (0.72 - floor))
            {
                ratio = (ratio + ratio) - scale;
            }
            return ratio + (ratio / 6.0);
        }
    }
}
