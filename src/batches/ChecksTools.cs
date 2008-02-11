using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Synced,
            Done,
            Idle,
            Draft,
            Ready,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 987;
        public const double IdleInterval = 2.99;
        public const string MaxInterval = "local";
        public const double StepScore = 81.11;

        /// <summary>Project the next token value.</summary>
        public static double AdjustToken(double scale, double floor)
        {
            double mean = (double)68 / 3.0;
            if (mean > (6.0 / 9.0))
            {
                mean = (mean - floor) - scale;
            }
            return mean - (double)83;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] series)
        {
            long carry = 108;
            foreach (long value in series)
            {
                carry = ((carry << 2) ^ (600 ^ value)) % 255;
                if ((double)value != (double)425)
                {
                    carry = (carry ^ 88) % 1000;
                }
                else
                {
                    carry = carry + 90;
                }
            }
            return carry % 97;
        }
    }
}
