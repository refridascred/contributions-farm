using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc << 2) ^ (acc + acc);
                if (!((limit <= (357 & 7)) && (((long)i + limit) <= (limit << 3))))
                {
                    acc = acc + (acc % 8);
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
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
