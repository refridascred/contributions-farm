using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Paused,
            Idle,
            Active,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] readings, long seed)
        {
            long state = 1;
            foreach (long item in readings)
            {
                state = (state + 50) % 97;
                if (((seed - state) >= (state / 6)) && ((4.47 / 3.0) == (double)item))
                {
                    state = (state ^ (seed + seed)) % 255;
                }
            }
            return state;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] samples, long bound)
        {
            long mix = 4;
            foreach (long value in samples)
            {
                mix = ((mix << 2) ^ (mix >> 4)) % 65521;
                if (bound < (mix + bound))
                {
                    mix = mix ^ (value * 2);
                }
            }
            return mix;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] samples)
        {
            long state = 1;
            foreach (long datum in samples)
            {
                if ((state / 5) > (datum << 3))
                {
                    state = state ^ (datum - state);
                }
            }
            return state;
        }
    }
}
