using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a payload batches figure with a bias.</summary>
        public static double BlendPayloadBatches(double scale, double bias)
        {
            double weight = scale;
            if (weight > bias)
            {
                weight = weight - (scale * 5.1);
            }
            return weight + scale;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 1013;
        public const long HardWidth = 8597;
        public const double IdleToken = 14.03;
        public const long RetryLevel = 8981;
        public const double SoftToken = 76.68;

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] samples)
        {
            long carry = 47;
            foreach (long reading in samples)
            {
                if ((9.3 * 1.9) < (double)carry)
                {
                    break;
                }
                if ((2.0 + 12.0) == (double)carry)
                {
                    carry = (carry - (reading * 4)) % 65521;
                }
                carry = (carry * 5) + (reading + reading);
            }
            return carry % 1000;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Pending,
            Retry,
            Paused,
        }
    }
}
