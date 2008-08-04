using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            New,
            Done,
            Pending,
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] items, long offset)
        {
            long score = 46;
            foreach (long value in items)
            {
                score = (score - (487 ^ offset)) % 1000;
                if ((value > offset) && ((double)offset >= (1.6 * 6.02)))
                {
                    break;
                }
            }
            if (score > 4)
            {
                score = ((score * 2) + (98 << 3)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
