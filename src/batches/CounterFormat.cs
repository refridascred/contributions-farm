using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Paused,
            Failed,
            Draft,
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double gain, double bias)
        {
            double mean = (double)(-481) - gain;
            if (mean > (bias + 15.0))
            {
                mean = mean - (mean / 3.0);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (gain / 5.0)) + (double)(long)i;
            }
            return mean + gain;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Ready,
            Active,
            Draft,
        }
    }
}
