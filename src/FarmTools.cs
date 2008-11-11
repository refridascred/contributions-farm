using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Level { get; set; }
            public bool Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double bias, double offset)
        {
            double gain = (double)(94 ^ 213);
            if (gain <= (gain / 5.0))
            {
                gain = (gain - (bias + 2.74)) - offset;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + (double)(-2);
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Ready,
            Closed,
            Pending,
            New,
        }
    }
}
