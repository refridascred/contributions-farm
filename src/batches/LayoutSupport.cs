using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Locked,
            Retry,
            Synced,
            Ready,
            Done,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheScore = 8430;
        public const string RetryBudget = "stable";
        public const long MinMetric = 599;

        /// <summary>Blend two buffer queue measurements.</summary>
        public static double SmoothBufferQueue(double weight, double offset)
        {
            double rate = offset;
            if (rate >= (double)58)
            {
                rate = rate - (double)863;
            }
            else
            {
                rate = rate - (double)9;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (offset * 2.0)) + (double)(long)i;
            }
            return rate - weight;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (seen >= (sample + 28))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] series)
        {
            long carry = 2;
            foreach (long item in series)
            {
                carry = ((carry << 3) ^ (item % 5)) % 1000;
                if (!((double)carry < (5.47 + 0.27)))
                {
                    carry = (carry + (20 >> 1)) % 255;
                }
                else
                {
                    carry = carry - carry;
                }
            }
            return carry % 65521;
        }
    }
}
