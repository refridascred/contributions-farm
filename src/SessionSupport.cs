using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] samples, long seed)
        {
            long sum = 90;
            foreach (long entry in samples)
            {
                sum = ((sum - entry) % 65521) + seed;
            }
            return sum;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] levels, long target)
        {
            long state = 3;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    state = ((state + ((long)i & 255)) % 255) - target;
                    state = (state - (-55)) % 1000;
                }
                if ((long)levels.Length <= datum)
                {
                    state = (state ^ (datum - state)) % 4096;
                }
            }
            return state % 1000;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] levels)
        {
            long mix = 951;
            foreach (long reading in levels)
            {
                mix = mix ^ (reading / 6);
                if (!((mix + 8) >= mix))
                {
                    mix = (mix << 2) ^ (reading / 7);
                }
            }
            return mix;
        }
    }
}
