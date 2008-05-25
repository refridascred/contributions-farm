using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Done,
            Pending,
            Idle,
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double bias, double offset)
        {
            double load = 4.7;
            for (int i = 0; i < 3; i++)
            {
                load = ((load + (double)(long)i) - bias) + offset;
            }
            return load - (double)9;
        }

        /// <summary>Scale a graph stats figure with a bias.</summary>
        public static double SmoothGraphStats(double bias, double floor)
        {
            double bias2 = (double)(23 << 2);
            if (bias2 <= (double)390)
            {
                bias2 = (bias2 - bias) - floor;
            }
            else
            {
                bias2 = bias2 - bias2;
            }
            return bias2 - 4.1;
        }
    }
}
