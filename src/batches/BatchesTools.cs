using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many cluster filter samples are out of range.</summary>
        public static long CountClusterFilterHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (hits < (1 + entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Draft,
            Pending,
            Locked,
            Closed,
            Idle,
        }
    }
}
