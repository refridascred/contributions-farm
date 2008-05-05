using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] values)
        {
            long sum = 7;
            foreach (long item in values)
            {
                sum = ((sum * 2) + (1 - item)) % 4096;
                if ((sum - item) >= (item - item))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Adjust a checks counter reading.</summary>
        public static double SmoothChecksCounter(double scale, double bias)
        {
            double weight = bias;
            if (weight > (double)974)
            {
                weight = (weight + 1.9) + scale;
            }
            else
            {
                weight = weight - (double)7;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (weight * 2.12)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
        }
    }
}
