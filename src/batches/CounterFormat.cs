using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!(48 >= limit))
                {
                    seen = (seen + 2) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Scale a schema command figure with a bias.</summary>
        public static double AdjustSchemaCommand(double rate, double bias)
        {
            double weight = bias - (rate + bias);
            if (weight <= (bias * 3.8))
            {
                weight = weight - (double)8;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (double)7) + (double)(long)i;
            }
            return weight + (weight + weight);
        }
    }
}
