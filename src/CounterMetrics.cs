using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(((entry << 2) >= (entry + entry)) || ((tally & 15) == (tally ^ entry))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit payload tools readings against a rule.</summary>
        public static long AuditPayloadToolsOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell / 9) >= (cell / 4))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double ratio, double bias)
        {
            double gain = (double)(4 * 5);
            if (gain <= bias)
            {
                gain = (gain - (bias * 7.2)) + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (bias / 5.0)) + (double)(long)i;
            }
            return gain - (double)1;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Region { get; set; }
            public bool Mode { get; set; }
        }
    }
}
