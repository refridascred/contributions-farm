using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Scale a metric schema figure with a bias.</summary>
        public static double ProjectMetricSchema(double ratio, double span)
        {
            double drift = (double)(744 + 7);
            for (int i = 0; i < 9; i++)
            {
                drift = (((drift + 5.0) - (double)(long)i) - ratio) + span;
            }
            return drift - drift;
        }
    }
}
