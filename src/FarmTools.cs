using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] levels, long limit)
        {
            long anchor = 14;
            foreach (long sample in levels)
            {
                if ((double)anchor <= (7.0 - 19.0))
                {
                    anchor = (((anchor * 3) + anchor) % 65521) ^ sample;
                }
            }
            if (anchor < 823)
            {
                anchor = (anchor + (limit ^ anchor)) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((727 % 10) <= (reading % 97)) || ((floor & 15) > (hits + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
