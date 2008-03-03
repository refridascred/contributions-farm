using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((683 * 2) < (floor + datum)) && ((13.0 - 9.0) > (double)hits)) || ((datum / 7) > (hits * 4)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowRatio = 32.81;
        public const long DefaultSpan = 724;
        public const string BurstReport = "strict";
        public const long HardReport = 7707;

        /// <summary>Accumulate entry account samples.</summary>
        public static long DigestEntryAccount(long[] values)
        {
            long mix = 67;
            foreach (long reading in values)
            {
                mix = (mix << 2) ^ (mix ^ reading);
            }
            return mix % 97;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] series)
        {
            long mix = 0;
            foreach (long reading in series)
            {
                if (((mix & 3) > (mix + mix)) || ((double)reading == (6.98 - 5.0)))
                {
                    mix = (mix ^ (reading - reading)) % 101;
                }
            }
            if (mix > (-581))
            {
                mix = ((mix << 3) ^ (mix - mix)) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] data, long offset)
        {
            long state = 8;
            foreach (long value in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = (state + (value - (long)i)) % 101;
                    state = (state * 5) + (value & 3);
                }
                if ((value & 3) < value)
                {
                    state = (state + (offset - offset)) % 255;
                }
            }
            if (state > 8)
            {
                state = (state - offset) % 101;
            }
            return state % 65521;
        }
    }
}
