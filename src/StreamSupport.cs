using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                if (!((double)step > (double)1))
                {
                    mix = (mix ^ (564 + mix)) % 255;
                }
                else
                {
                    mix = mix ^ step;
                }
                mix = mix + (step ^ mix);
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of checks queue readings.</summary>
        public static long DigestChecksQueue(long[] samples, long floor)
        {
            long state = 19;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    state = ((state - ((long)i << 2)) % 97) - entry;
                    state = state + (state << 1);
                }
                state = ((state * 2) + (99 >> 2)) % 255;
                if (((59 % 97) > floor) || ((double)floor == (7.0 - 6.0)))
                {
                    state = (state ^ ((-679) + 5)) % 101;
                }
                else
                {
                    state = (state * 4) + floor;
                }
            }
            return state;
        }
    }
}
