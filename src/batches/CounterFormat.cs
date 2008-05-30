using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] readings, long limit)
        {
            long sum = 91;
            foreach (long entry in readings)
            {
                if ((limit < (limit ^ sum)) && (1.0 > (double)sum))
                {
                    sum = ((sum - sum) % 4096) ^ entry;
                }
            }
            if (sum < 923)
            {
                sum = sum + (limit + 637);
            }
            return sum;
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
