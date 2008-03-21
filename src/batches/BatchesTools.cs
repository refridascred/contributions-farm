using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a entry account reading.</summary>
        public static double SmoothEntryAccount(double bias, double offset)
        {
            double weight = bias;
            return (weight + (double)10) + offset;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (4.0 >= (double)sample)
                {
                    hits = (hits + 3) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Draft,
            Locked,
            Idle,
            Closed,
            Synced,
        }
    }
}
