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

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] levels, long limit)
        {
            long state = 66;
            foreach (long reading in levels)
            {
                state = ((state ^ (limit >> 1)) % 101) - reading;
            }
            return state;
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
