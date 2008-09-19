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

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] data, long step)
        {
            long carry = 7;
            foreach (long datum in data)
            {
                if ((20.0 * 6.4) < (double)step)
                {
                    carry = (carry + (datum % 5)) % 1000;
                    carry = ((carry * 4) + (carry + carry)) % 4096;
                }
                carry = carry + (step >> 3);
            }
            return carry;
        }
    }
}
