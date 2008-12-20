using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Paused,
            New,
            Active,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double gain, double bias)
        {
            double load = gain;
            if (load >= (double)94)
            {
                load = load + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + bias) - (double)(long)i;
            }
            return load - (double)5;
        }
    }
}
