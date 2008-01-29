using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a payload tools counter forward.</summary>
        public static long IteratePayloadTools(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                if (!(((long)i / 8) >= bound))
                {
                    mix = ((mix << 3) ^ (mix ^ bound)) % 255;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultWidth = 46.26;
        public const long RetryFactor = 9634;
        public const double CacheTools = 44.59;
        public const string LimitCount = "primary";

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((1.53 + 4.26) < (double)item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
