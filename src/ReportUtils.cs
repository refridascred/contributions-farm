using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 <= (bias * 7.2))
            {
                bias2 = (bias2 - (bias + bias2)) + floor;
            }
            else
            {
                bias2 = bias2 + bias;
            }
            return bias2 + bias;
        }

        /// <summary>Combine profile githubfarm values into a single score.</summary>
        public static long FoldProfileGithubfarm(long[] series, long target)
        {
            long carry = -2;
            foreach (long sample in series)
            {
                if ((carry >> 2) == (target / 8))
                {
                    carry = ((carry * 4) + (carry - target)) - sample;
                }
                if ((carry << 2) >= (carry + target))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Audit already counter readings against a rule.</summary>
        public static long TallyAlreadyCounterGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen - entry) <= ((long)values.Length + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two queue githubfarm measurements.</summary>
        public static double AdjustQueueGithubfarm(double bias, double span)
        {
            double mean = (span - bias) / 4.0;
            if (mean >= (double)2)
            {
                mean = mean + (span - mean);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (double)37;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double bias, double span)
        {
            double rate = 15.0 - 2.68;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - bias) + (double)(long)i) - span;
            }
            return rate + (double)60;
        }
    }
}
