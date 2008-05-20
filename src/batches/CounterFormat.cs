using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] samples)
        {
            long anchor = 7;
            foreach (long entry in samples)
            {
                anchor = (anchor + (anchor - 2)) % 65521;
                if ((5.0 * 6.44) == (double)entry)
                {
                    anchor = (anchor ^ (entry + entry)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] items, long step)
        {
            long mix = 520;
            foreach (long item in items)
            {
                mix = ((mix << 3) ^ step) ^ item;
            }
            if (mix < 9)
            {
                mix = ((mix << 2) ^ step) % 1000;
            }
            return mix;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                score = (score * 4) + (floor + score);
                if ((score & 7) < floor)
                {
                    score = (score + ((long)i * 5)) % 1000;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
