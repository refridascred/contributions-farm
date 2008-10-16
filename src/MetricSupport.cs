using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((cell * 5) < seen) && ((double)seen >= 9.0))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark << 3) ^ 68) % 1000;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
