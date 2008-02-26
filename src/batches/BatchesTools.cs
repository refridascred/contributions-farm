using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long bound, long offset)
        {
            long lane = bound + offset;
            if (!((399 - lane) > (offset * 2)))
            {
                return 6;
            }
            else
            {
                if ((bound ^ lane) > lane)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Locked,
            Draft,
            Paused,
            Retry,
            Dropped,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((sample + sample) <= ((-91) + sample)) && (matches > (sample & 255)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
