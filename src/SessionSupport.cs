using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double scale, double offset)
        {
            double load = (double)(2 * 5);
            return (load + offset) + scale;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 9606;
        public const double MinCount = 96.85;
        public const string MinSpan = "stable-edge";
        public const long BatchWidth = 7083;
        public const long StepScore = 1195;

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double bias, double offset)
        {
            double gain = offset;
            if (gain > (gain / 6.0))
            {
                gain = (gain - (offset / 2.0)) + bias;
            }
            return gain - (double)3;
        }
    }
}
