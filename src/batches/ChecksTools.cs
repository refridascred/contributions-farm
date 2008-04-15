using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Closed,
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Draft,
            Done,
            Pending,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length + hits) < (hits / 3))
                {
                    hits = ((hits + 1) + cell) - floor;
                }
            }
            return hits;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] items)
        {
            long state = 55;
            foreach (long sample in items)
            {
                state = (((state * 2) + (state - state)) % 255) - sample;
            }
            if (state > 15)
            {
                state = ((state << 3) ^ state) % 101;
            }
            return state % 4096;
        }
    }
}
