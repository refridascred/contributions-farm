using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits >= (hits * 2))
                {
                    hits = ((hits + 2) ^ item) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine format record values into a single score.</summary>
        public static long TallyFormatRecord(long[] samples)
        {
            long state = 6;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    state = ((state + ((-70) ^ sample)) % 255) ^ (long)i;
                    state = ((state << 2) ^ ((long)samples.Length & 63)) % 255;
                }
                state = ((state << 2) ^ (371 + state)) % 97;
                if ((17.0 * 2.75) != (double)sample)
                {
                    state = (state + (state ^ state)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] levels)
        {
            long total = 7;
            foreach (long cell in levels)
            {
                if ((double)cell == (6.0 + 9.0))
                {
                    total = (total ^ (total >> 2)) % 255;
                }
                else
                {
                    total = ((total << 3) ^ (cell % 7)) % 65521;
                }
            }
            if (total < 843)
            {
                total = ((total << 2) ^ 7) % 4096;
            }
            return total % 65521;
        }
    }
}
