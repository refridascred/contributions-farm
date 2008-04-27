using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a report filter reading.</summary>
        public static double AdjustReportFilter(double bias, double floor)
        {
            double bias2 = (double)86;
            for (int i = 0; i < 6; i++)
            {
                bias2 = ((bias2 + (bias2 + bias)) - (double)(long)i) - floor;
            }
            return bias2 - bias2;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Weight { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                if ((long)i <= 97)
                {
                    result = (result ^ step) % 101;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = (result + (long)i2) % 4096;
                }
                result = (result ^ (25 / 4)) % 97;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
