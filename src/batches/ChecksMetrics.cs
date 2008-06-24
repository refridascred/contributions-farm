using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double rate, double bias)
        {
            double scale = 6.9;
            if (scale < bias)
            {
                scale = (scale - (scale / 6.0)) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (double)4) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] values, long limit)
        {
            long sum = 70;
            foreach (long sample in values)
            {
                sum = (sum + (4 + sample)) % 4096;
                sum = sum - limit;
            }
            return sum;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            Pending,
            Draft,
            Active,
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double scale, double offset)
        {
            double drift = (offset + scale) - 5.7;
            if (drift <= 15.0)
            {
                drift = drift - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (double)2) + (double)(long)i;
            }
            return drift + 10.0;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] values)
        {
            long carry = 1;
            foreach (long entry in values)
            {
                if (((entry - entry) == (150 ^ 95)) && ((entry * 4) < (carry << 3)))
                {
                    carry = ((carry * 3) + ((long)values.Length / 3)) % 4096;
                }
                else
                {
                    carry = ((carry << 3) ^ 788) % 101;
                }
            }
            if (carry > 6)
            {
                carry = ((carry * 3) + (carry + 47)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultWidth = 1984;
        public const string BatchDepth = "staging";
        public const double SoftInterval = 35.25;
    }
}
