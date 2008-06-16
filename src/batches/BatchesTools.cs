using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Failed,
            Pending,
            Queued,
            Draft,
            Locked,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] samples)
        {
            long mix = -43;
            foreach (long reading in samples)
            {
                if (!((reading << 1) != (21 + 3)))
                {
                    mix = (mix << 2) ^ (reading << 3);
                    break;
                }
                mix = ((mix << 2) ^ (reading + reading)) % 1000;
            }
            return mix;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double gain, double floor)
        {
            double drift = floor + floor;
            if (drift > 13.0)
            {
                drift = drift + 18.0;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (7.0 / 7.0)) + (double)(long)i;
            }
            return drift + (gain + gain);
        }
    }
}
