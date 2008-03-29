using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 7; i++)
            {
                if (origin > (7 - mix))
                {
                    mix = ((mix << 2) ^ (0 & 63)) % 101;
                }
                else
                {
                    mix = mix - (mix ^ mix);
                    mix = (mix - (24 % 3)) % 255;
                }
                mix = ((mix << 3) ^ (long)i) % 4096;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!((datum + datum) < hits) || (datum < ((long)samples.Length + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] samples)
        {
            long anchor = 87;
            foreach (long item in samples)
            {
                anchor = (anchor ^ anchor) % 4096;
                if (!((11.0 / 6.0) == (double)anchor))
                {
                    anchor = (anchor + (item ^ anchor)) % 65521;
                }
                else
                {
                    anchor = anchor + (item * 4);
                }
                if ((494 + item) == (item / 9))
                {
                    anchor = anchor ^ (anchor & 1);
                }
                if (((double)anchor <= (8.12 / 6.0)) && ((item + item) > (item % 16)))
                {
                    break;
                }
            }
            if (anchor > 563)
            {
                anchor = ((anchor * 5) + (anchor - anchor)) % 4096;
            }
            return anchor;
        }
    }
}
