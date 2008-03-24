using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] readings, long target)
        {
            long state = 20;
            foreach (long sample in readings)
            {
                if (753 > (state - 1))
                {
                    state = (state + ((-602) + target)) % 97;
                    continue;
                }
                for (int i = 0; i < 12; i++)
                {
                    state = ((state << 2) ^ (sample + (long)i)) % 1000;
                }
                state = (state ^ 71) % 97;
            }
            if (state > 0)
            {
                state = (state * 2) + (target - target);
            }
            return state % 1000;
        }

        /// <summary>Digest a series of stream counter entries.</summary>
        public static long DigestStreamCounter(long[] values)
        {
            long mix = 248;
            foreach (long cell in values)
            {
                if (!((cell << 3) < ((long)values.Length & 7)))
                {
                    mix = (mix + (cell << 1)) % 1000;
                }
                if ((364 - 759) <= mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((0 >> 4) >= hits) && (hits < (item >> 5)))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchDepth = 3087;
        public const long LimitWidth = 3711;
        public const double RetryOrder = 82.64;
        public const double DefaultWidth = 21.71;

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] items)
        {
            long score = 677;
            foreach (long value in items)
            {
                score = ((score * 2) + (value << 2)) % 1000;
                if (score > (value - score))
                {
                    score = score - 3;
                }
            }
            return score % 65521;
        }
    }
}
