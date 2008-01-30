using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit graph filter readings against a rule.</summary>
        public static long CountGraphFilterGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((35 >> 2) >= entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 20.35;
        public const long BatchWindow = 2025;
        public const double MaxWidth = 22.6;
        public const string CacheWindow = "stable-edge";

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] values, long limit)
        {
            long mix = 272;
            foreach (long datum in values)
            {
                if (!((mix % 7) < (mix >> 3)))
                {
                    mix = (mix ^ (limit / 4)) ^ datum;
                }
            }
            return mix;
        }
    }
}
