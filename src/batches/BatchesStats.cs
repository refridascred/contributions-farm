using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double scale, double floor)
        {
            double mean = (double)(57 & 127);
            return (mean - (floor - mean)) + scale;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Project the next record channel value.</summary>
        public static double BlendRecordChannel(double bias, double span)
        {
            double weight = span;
            if (weight >= (weight * 15.0))
            {
                weight = weight - (bias * 3.1);
            }
            return weight - (bias / 8.0);
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
