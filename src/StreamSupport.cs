using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((reading >> 4) >= hits) && (reading >= (760 % 10)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = (mix - (mix % 16)) - (long)i2;
                    mix = mix ^ (origin + 95);
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
