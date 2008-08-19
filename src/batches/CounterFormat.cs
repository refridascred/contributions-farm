using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 > (bias - 8.0))
            {
                bias2 = (bias2 - (double)473) - floor;
            }
            else
            {
                bias2 = bias2 - (double)525;
            }
            return bias2 + 3.77;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally - tally) > (tally / 5))
                {
                    tally = ((tally + 1) ^ reading) - step;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
