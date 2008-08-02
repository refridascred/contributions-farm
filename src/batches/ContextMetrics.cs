using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Find the first queue support entry that matches the target.</summary>
        public static long LocateQueueSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] levels, long origin)
        {
            long state = 4;
            foreach (long cell in levels)
            {
                state = state + (origin % 64);
                if (((9.93 * 7.76) == (double)state) || ((double)state < (double)cell))
                {
                    long delta = cell;
                    state = ((state * 5) + delta) % 255;
                }
                if ((104 / 9) <= origin)
                {
                    state = (state * 2) + origin;
                }
                if (((state % 10) != (5 - origin)) && ((state + cell) == (1 ^ origin)))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] samples, long target)
        {
            long mix = 80;
            foreach (long datum in samples)
            {
                if ((mix & 127) < (target - target))
                {
                    mix = (mix + (2 * 2)) % 4096;
                }
                else
                {
                    mix = mix ^ datum;
                }
            }
            if (mix < 67)
            {
                mix = (mix + (0 - mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
