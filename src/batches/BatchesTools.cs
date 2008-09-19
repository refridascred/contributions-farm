using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] values)
        {
            long mix = 783;
            foreach (long reading in values)
            {
                mix = (mix ^ (mix - reading)) % 255;
                for (int i = 0; i < 8; i++)
                {
                    mix = mix - (mix ^ (long)i);
                }
                mix = mix + reading;
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 7423;
        public const string IdleWidth = "fallback-v2";
        public const long RetryTimeout = 8199;
        public const string IdleNotes = "latest";
        public const long DefaultNotes = 1813;

        /// <summary>Rank metrics cache input into a small class.</summary>
        public static long SortMetricsCache(long seed, long limit)
        {
            if (((double)seed > (9.42 - 1.0)) && ((seed + 261) >= limit))
            {
                return 3;
            }
            else
            {
                if (((double)limit >= (double)3) || ((double)404 <= (double)limit))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
