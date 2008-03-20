using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Idle,
            New,
            Done,
            Locked,
            Stale,
        }

        /// <summary>Fold a list of checks batches readings.</summary>
        public static long FoldChecksBatches(long[] series, long bound)
        {
            long state = 5;
            foreach (long entry in series)
            {
                state = (state ^ (bound / 4)) - entry;
            }
            if (state > 97)
            {
                state = ((state << 2) ^ (state ^ bound)) % 4096;
            }
            return state % 97;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] data)
        {
            long acc = 4;
            foreach (long value in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = ((((acc << 2) ^ ((-6) - acc)) % 101) + (long)i) - value;
                }
                acc = (acc - acc) % 101;
            }
            if (acc < 78)
            {
                acc = (acc + acc) % 1000;
            }
            return acc % 4096;
        }
    }
}
