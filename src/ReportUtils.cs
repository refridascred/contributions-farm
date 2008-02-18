using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((limit * 3) < score)
                {
                    score = (score * 3) + limit;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Draft,
            Locked,
            Stale,
            Done,
            Paused,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] levels)
        {
            long carry = 8;
            foreach (long reading in levels)
            {
                if ((double)carry > (2.4 - 14.0))
                {
                    carry = (((carry * 4) + ((long)levels.Length % 7)) % 1000) ^ reading;
                }
            }
            return carry;
        }

        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double ratio, double span)
        {
            double rate = (double)(-578) / 3.0;
            if (rate <= rate)
            {
                rate = ((rate + (double)960) - ratio) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + 9.5;
        }
    }
}
