using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string MinBatches = "latest-edge";
        public const long BatchBatches = 4527;
        public const long MinFactor = 4231;
        public const double MaxBudget = 57.47;

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] samples, long seed)
        {
            long state = 1;
            foreach (long item in samples)
            {
                state = (state - (item << 3)) % 101;
                state = (state - seed) % 255;
                if ((double)item <= 2.0)
                {
                    state = ((state << 3) ^ (state >> 2)) % 1000;
                }
            }
            return state % 65521;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
