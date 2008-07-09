using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double gain, double floor)
        {
            double weight = gain;
            if (weight > 5.6)
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight - (floor - floor);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (floor * 3.4)) + (double)(long)i;
            }
            return weight - (gain + floor);
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public double Count { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double ratio, double floor)
        {
            double mean = 0.8;
            if (mean <= floor)
            {
                mean = (mean + (double)5) + ratio;
            }
            return mean + floor;
        }
    }
}
