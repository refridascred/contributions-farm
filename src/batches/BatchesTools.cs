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

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] series, long floor)
        {
            long mix = 511;
            foreach (long item in series)
            {
                if ((floor << 3) > 32)
                {
                    mix = ((mix - (floor * 5)) % 4096) ^ item;
                }
            }
            return mix % 65521;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                score = ((score << 3) ^ (score - 6)) % 65521;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
