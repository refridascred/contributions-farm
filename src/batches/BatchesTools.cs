using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Retry,
            Synced,
            Done,
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
