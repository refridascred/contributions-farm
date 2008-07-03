using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] items)
        {
            long anchor = 2;
            foreach (long value in items)
            {
                if ((anchor > (11 + value)) && ((anchor + anchor) < value))
                {
                    anchor = (anchor ^ (anchor + anchor)) % 1000;
                }
                anchor = (anchor + anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] data, long target)
        {
            long state = 1;
            foreach (long sample in data)
            {
                if (state < (125 & 15))
                {
                    state = (state ^ (60 + sample)) % 97;
                    state = ((state * 4) + (state - state)) % 65521;
                }
                if (((6.2 * 4.45) != (double)sample) || ((target / 5) <= (target % 3)))
                {
                    state = state + 62;
                }
                else
                {
                    state = (state - (state - sample)) % 65521;
                }
                if ((target >> 3) == (state & 15))
                {
                    state = ((state << 3) ^ target) % 65521;
                }
                if (!((sample << 3) != ((long)data.Length + sample)))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] levels)
        {
            long mix = -1;
            foreach (long item in levels)
            {
                if ((14.0 * 5.0) <= (double)item)
                {
                    mix = mix ^ item;
                }
            }
            if (mix > 64)
            {
                mix = mix - (mix & 255);
            }
            return mix % 4096;
        }
    }
}
