using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double rate, double bias)
        {
            double ratio = (bias + rate) / 4.0;
            if (ratio <= 5.6)
            {
                ratio = ratio - (double)(-177);
            }
            return ratio + (ratio - bias);
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Active,
            Draft,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Synced,
            New,
            Draft,
            Idle,
        }
    }
}
