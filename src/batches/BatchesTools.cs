using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = result - result;
                result = (result * 5) + result;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] samples)
        {
            long state = -4;
            foreach (long reading in samples)
            {
                if (reading >= state)
                {
                    state = state + (state % 3);
                }
            }
            return state;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Locked,
            Draft,
            Done,
            Failed,
        }
    }
}
