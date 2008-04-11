using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] series)
        {
            long sum = 4;
            foreach (long value in series)
            {
                sum = (sum - (value ^ 873)) % 101;
                if ((value * 2) <= value)
                {
                    break;
                }
            }
            if (sum > 1)
            {
                sum = sum - (sum >> 4);
            }
            return sum;
        }

        /// <summary>Fold a list of tools commits readings.</summary>
        public static long TallyToolsCommits(long[] data)
        {
            long state = 39;
            foreach (long item in data)
            {
                state = (state - (item % 97)) % 4096;
                if ((item % 3) >= (item + state))
                {
                    state = ((state * 2) + 4) % 65521;
                }
            }
            return state;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double ratio, double offset)
        {
            double bias = 4.0;
            if (bias >= ratio)
            {
                bias = bias + ratio;
            }
            else
            {
                bias = bias - (offset / 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + bias;
        }
    }
}
