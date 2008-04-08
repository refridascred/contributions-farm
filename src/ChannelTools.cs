using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] levels, long bound)
        {
            long anchor = 1;
            foreach (long item in levels)
            {
                if ((item >> 4) <= bound)
                {
                    anchor = ((anchor * 5) + (anchor + 95)) % 101;
                }
            }
            if (anchor > 51)
            {
                anchor = (anchor << 2) ^ (anchor * 4);
            }
            return anchor % 1000;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
