using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Synced,
            Active,
            Locked,
        }

        /// <summary>Scale a report tools figure with a bias.</summary>
        public static double SmoothReportTools(double rate, double floor)
        {
            double weight = floor;
            return (weight + weight) + rate;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double ratio, double span)
        {
            double mean = (8.6 + 9.4) + span;
            if (mean > span)
            {
                mean = (mean + 0.9) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (12.0 / 3.0)) + (double)(long)i;
            }
            return mean - span;
        }
    }
}
