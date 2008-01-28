using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Done,
            Queued,
            Pending,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstWidth = 3187;
        public const long IdleCounter = 4866;
        public const long MinCounter = 8232;
        public const double BurstCounter = 65.6;
        public const long BaseSpan = 4114;

        /// <summary>Project the next checks account value.</summary>
        public static double SmoothChecksAccount(double gain, double bias)
        {
            double bias2 = gain;
            if (bias2 > bias)
            {
                bias2 = bias2 - (bias * 3.94);
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - (bias * 8.77)) + (double)(long)i;
            }
            return bias2 - (double)56;
        }
    }
}
