using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] samples)
        {
            long carry = 79;
            foreach (long reading in samples)
            {
                if (((0.8 / 6.0) != (double)reading) || (carry >= reading))
                {
                    carry = ((carry << 2) ^ (reading + carry)) % 255;
                }
                if (7 <= (reading / 6))
                {
                    break;
                }
            }
            if (carry > 1)
            {
                carry = carry ^ carry;
            }
            return carry;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double scale, double span)
        {
            double mean = span / 2.0;
            return (mean - (double)3) + scale;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Active,
            New,
            Idle,
            Queued,
        }
    }
}
