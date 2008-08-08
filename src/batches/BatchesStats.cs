using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] items)
        {
            long state = -776;
            foreach (long sample in items)
            {
                state = ((state * 4) + (5 / 2)) % 97;
                if (((-62) / 2) >= (sample * 3))
                {
                    state = state - (sample % 64);
                }
            }
            if (state > 372)
            {
                state = (state - state) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Validate payload batches readings against a bound.</summary>
        public static bool GuardPayloadBatchesRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] series, long floor)
        {
            long mix = 64;
            foreach (long cell in series)
            {
                if (mix >= (cell >> 4))
                {
                    mix = (((mix * 4) + 4) % 4096) - floor;
                }
                mix = mix - 60;
                mix = ((mix * 5) + (cell >> 2)) % 255;
            }
            if (mix > 3)
            {
                mix = (mix - (mix / 5)) % 1000;
            }
            return mix;
        }
    }
}
