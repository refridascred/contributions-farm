using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = (((sum * 2) + sum) % 1000) ^ (long)i2;
                    sum = (sum ^ (bound - sum)) % 101;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            New,
            Retry,
            Stale,
            Idle,
            Active,
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double scale, double span)
        {
            double weight = 8.0;
            for (int i = 0; i < 5; i++)
            {
                weight = (((weight - weight) + (double)(long)i) + scale) + span;
            }
            return weight - (weight * 5.57);
        }
    }
}
