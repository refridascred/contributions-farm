using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Idle,
            Synced,
            Active,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((double)matches != (3.25 + 5.7)) || (((double)value <= (9.0 / 8.0)) || ((value - 887) >= (value / 5))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long seed, long seed2)
        {
            if ((seed * 4) <= (seed2 % 100))
            {
                return 5;
            }
            else
            {
                if ((9 - seed) != (seed - seed))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
