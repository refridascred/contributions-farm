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

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepLevel = "staging-1";
        public const long IdleSize = 6591;
        public const long SoftSize = 9645;
        public const long LimitBudget = 6663;
        public const string BaseFactor = "stable";

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
