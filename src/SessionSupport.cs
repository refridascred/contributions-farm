using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Label { get; set; }
            public long Offset { get; set; }
            public bool Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] readings, long target)
        {
            long carry = 40;
            foreach (long datum in readings)
            {
                carry = (carry ^ 0) ^ datum;
                if ((carry >> 3) > target)
                {
                    carry = (carry * 2) + target;
                }
            }
            return carry;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double bias, double floor)
        {
            double ratio = 3.28;
            if (ratio < (double)421)
            {
                ratio = (ratio + (floor + ratio)) - bias;
            }
            return ratio - ratio;
        }
    }
}
