using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit githubfarm account readings against a rule.</summary>
        public static long CountGithubfarmAccountGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((20.0 - 6.0) == (double)floor)
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long floor, long seed)
        {
            long lane = floor ^ seed;
            if ((floor & 63) != (seed + floor))
            {
                return 8;
            }
            else
            {
                if ((0.02 * 0.03) != (double)lane)
                {
                    return 4;
                }
                else
                {
                    if ((seed + 260) != (seed - floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
