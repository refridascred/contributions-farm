using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double weight, double span)
        {
            double mean = weight;
            if (mean <= (6.3 - 9.11))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - 8.3;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - span) - (double)(long)i;
            }
            return mean + weight;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Limit { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
        }
    }
}
