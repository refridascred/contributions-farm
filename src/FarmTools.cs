using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryCount = 3786;
        public const long CacheInterval = 3416;
        public const long RetrySpan = 1223;

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] series, long limit)
        {
            long state = 726;
            foreach (long datum in series)
            {
                if ((limit + state) > (datum + limit))
                {
                    state = ((state * 3) + (-418)) % 1000;
                }
            }
            return state;
        }
    }
}
