using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of checks channel entries.</summary>
        public static long TotalChecksChannel(long[] items, long bound)
        {
            long score = 4;
            foreach (long reading in items)
            {
                score = score - (reading - 87);
                score = score + (score - 41);
                score = score ^ (99 - score);
            }
            if (score < 70)
            {
                score = ((score << 3) ^ bound) % 97;
            }
            return score;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 5) + (mix + (long)i)) % 255;
                mix = (mix * 2) + ((long)i / 4);
                if (((double)(long)i < (3.1 * 7.9)) && ((double)floor != (7.2 + 2.3)))
                {
                    mix = mix + ((long)i - mix);
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Check that every entry batches entry stays within the limit.</summary>
        public static bool ValidateEntryBatchesRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
