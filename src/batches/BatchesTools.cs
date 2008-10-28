using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryCount = 270;
        public const string WindowProfile = "staging-v2";
        public const string IdleSpan = "latest";
        public const long CacheFactor = 3162;

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] series)
        {
            long state = 27;
            foreach (long cell in series)
            {
                if ((255 * 5) >= (state * 4))
                {
                    state = ((state + ((long)series.Length + state)) % 65521) ^ cell;
                }
            }
            if (state > (-8))
            {
                state = (state << 2) ^ (state - 69);
            }
            return state;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double gain, double span)
        {
            double mean = (double)871 / 8.0;
            if (mean <= (gain / 5.0))
            {
                mean = (mean - (double)3) + span;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (gain / 9.0)) + (double)(long)i;
            }
            return mean + (double)36;
        }
    }
}
