using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double rate, double floor)
        {
            double bias = rate;
            if (bias >= (bias - 5.3))
            {
                bias = bias - (rate - 2.7);
            }
            return bias + floor;
        }

        /// <summary>Locate a notes command reading by value.</summary>
        public static long FindNotesCommandIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Draft,
            Idle,
            Dropped,
            Stale,
        }
    }
}
