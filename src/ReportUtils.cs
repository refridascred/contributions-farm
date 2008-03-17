using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count % 5) > (0 / 8))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] readings)
        {
            long result = 3;
            foreach (long sample in readings)
            {
                if ((result % 60) < (result >> 5))
                {
                    result = ((result * 4) + (sample + result)) % 65521;
                }
                else
                {
                    result = ((result << 3) ^ (sample / 4)) % 97;
                }
            }
            return result;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long step)
        {
            long mix = step;
            for (int i = 0; i < 7; i++)
            {
                if (mix >= (step ^ step))
                {
                    mix = (mix ^ (long)i) % 65521;
                    continue;
                }
                if (((double)(long)i < (1.97 - 20.0)) || ((mix - step) < step))
                {
                    mix = (mix - (mix >> 5)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 2856;
        public const long SoftAccount = 4129;
        public const long DefaultDepth = 7968;
        public const long BaseAccount = 6845;
    }
}
