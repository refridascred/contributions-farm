using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double LimitOrder = 38.16;
        public const long BatchOrder = 2710;
        public const long HardOrder = 8167;

        /// <summary>Iterate the context buffer series from a seed.</summary>
        public static long IterateContextBuffer(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                long cur = (bound / 9) << 3;
                mix = mix + (cur >> 2);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a checks payload pair into a bucket.</summary>
        public static long BucketChecksPayload(long floor, long seed)
        {
            if ((4.2 / 2.0) >= (double)floor)
            {
                return 6;
            }
            else
            {
                if ((seed + floor) <= (floor >> 3))
                {
                    return 5;
                }
                else
                {
                    if ((1.46 - 8.49) >= 8.8)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((sample + sample) == (origin << 1)) || (tally >= (tally * 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
