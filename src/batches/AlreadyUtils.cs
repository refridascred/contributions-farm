using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double scale, double offset)
        {
            double gain = offset;
            if (gain <= offset)
            {
                gain = gain - 6.79;
            }
            return gain - (scale - gain);
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] readings)
        {
            long carry = -51;
            foreach (long item in readings)
            {
                carry = (carry - (long)readings.Length) ^ item;
            }
            if (carry > 44)
            {
                carry = ((carry << 3) ^ (carry + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
