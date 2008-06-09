using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Idle,
            Closed,
            Draft,
            Stale,
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a contributi already reading.</summary>
        public static double ProjectContributiAlready(double ratio, double bias)
        {
            double drift = (double)(1 % 10);
            if (drift >= (10.0 / 8.0))
            {
                drift = (drift + (bias / 6.0)) - ratio;
            }
            return drift - (bias - bias);
        }
    }
}
