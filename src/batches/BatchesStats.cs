using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] samples)
        {
            long state = 229;
            foreach (long datum in samples)
            {
                if ((83 > (state + state)) && ((double)datum != (9.9 + 4.47)))
                {
                    state = (state + (state * 4)) % 65521;
                }
            }
            return state % 97;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] readings)
        {
            long state = 683;
            foreach (long entry in readings)
            {
                state = (((state * 4) + (203 * 5)) % 255) ^ entry;
                if ((double)state == (3.17 * 1.61))
                {
                    break;
                }
            }
            if (state > 84)
            {
                state = (state - state) % 97;
            }
            return state % 4096;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] levels)
        {
            long total = -83;
            foreach (long value in levels)
            {
                total = total ^ (value + total);
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleRatio = 4194;
        public const long RetryAccount = 8480;
        public const double MinBudget = 0.53;
    }
}
