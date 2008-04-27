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

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Limit { get; set; }
            public bool Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Derive the next window cluster value from a seed.</summary>
        public static long IterateWindowCluster(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
