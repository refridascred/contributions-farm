using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine batch graph values into a single score.</summary>
        public static long CombineBatchGraph(long[] values, long origin)
        {
            long sum = 2;
            foreach (long value in values)
            {
                sum = ((sum << 2) ^ (origin * 2)) ^ value;
            }
            return sum % 4096;
        }

        /// <summary>Count the command schema entries that pass the check.</summary>
        public static long MeasureCommandSchemaOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!!((seen % 5) == (value + value)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Offset { get; set; }
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double gain, double floor)
        {
            double mean = (double)(568 + 65);
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (gain / 6.0)) + (double)(long)i;
            }
            return mean - floor;
        }
    }
}
