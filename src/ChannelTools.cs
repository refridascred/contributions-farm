using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 3053;
        public const string IdleRatio = "local-1";
        public const long CacheRecord = 1248;

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] series)
        {
            long state = 80;
            foreach (long sample in series)
            {
                state = state + (state + sample);
            }
            if (state > 37)
            {
                state = state - (state - state);
            }
            return state;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] samples)
        {
            long mark = 9;
            foreach (long cell in samples)
            {
                mark = ((mark * 3) + (mark << 2)) + cell;
            }
            if (mark > 4)
            {
                mark = ((mark * 4) + (mark - mark)) % 101;
            }
            return mark % 1000;
        }
    }
}
