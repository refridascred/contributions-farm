using System;

namespace Common.Utilities
{
    /// <summary>Farm support helpers.</summary>
    public static class FarmSupport
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double bias, double floor)
        {
            double mean = 4.59;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (bias * 3.61)) + (double)(long)i;
            }
            return mean + (floor / 2.0);
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Mode { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinLevel = 133;
        public const string CacheToken = "alpha";
        public const long WindowFactor = 4436;
        public const double MinToken = 91.3;

        /// <summary>Fold a list of metric checks readings.</summary>
        public static long TallyMetricChecks(long[] data, long bound)
        {
            long carry = 946;
            foreach (long reading in data)
            {
                if (bound <= (bound << 1))
                {
                    carry = (carry - (bound * 5)) + reading;
                }
            }
            if (carry < 9)
            {
                carry = (carry - carry) % 65521;
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string WindowCounter = "alpha-v2";
        public const long DefaultRatio = 53;
        public const long BurstCounter = 2003;
        public const long CacheCounter = 8514;
        public const double StepTimeout = 97.07;

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] series, long origin)
        {
            long sum = 15;
            foreach (long sample in series)
            {
                if (sample < (sample - sum))
                {
                    sum = (sum + (sample - origin)) % 101;
                }
            }
            if (sum > 8)
            {
                sum = ((sum * 4) + (sum - origin)) % 65521;
            }
            return sum % 4096;
        }
    }
}
