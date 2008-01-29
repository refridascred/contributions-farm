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

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long limit, long origin)
        {
            if (origin < (origin & 31))
            {
                return 3;
            }
            else
            {
                if ((double)origin <= 18.0)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

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
