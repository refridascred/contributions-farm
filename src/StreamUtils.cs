using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public long Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Count the counter support entries that pass the check.</summary>
        public static long MeasureCounterSupportHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((8.6 + 19.0) == (double)sample)
                {
                    matches = (matches + 3) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] items, long floor)
        {
            long score = 4;
            foreach (long reading in items)
            {
                if ((1.97 / 2.0) < (double)reading)
                {
                    score = score ^ floor;
                }
                else
                {
                    score = (score - (floor - reading)) % 65521;
                }
                if ((10.0 - 9.1) > (8.0 * 5.22))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((step & 127) < (step / 7))
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long bound)
        {
            long state = bound;
            for (int i = 0; i < 17; i++)
            {
                state = (state ^ (state * 5)) % 97;
                state = ((state << 2) ^ (state - state)) % 65521;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Combine payload notes values into a single score.</summary>
        public static long DigestPayloadNotes(long[] samples, long target)
        {
            long mark = 52;
            foreach (long sample in samples)
            {
                mark = (((mark << 3) ^ (sample + mark)) % 4096) - target;
            }
            return mark % 97;
        }
    }
}
