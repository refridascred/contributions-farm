using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long origin, long origin2)
        {
            if (((origin + origin) <= origin) && ((origin2 - origin) == (origin2 + origin)))
            {
                return 4;
            }
            else
            {
                if ((double)origin <= (5.8 - 6.3))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Derive the next account cache value from a seed.</summary>
        public static long IterateAccountCache(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                if (((double)(-5) <= (double)score) && ((double)floor <= 5.1))
                {
                    score = (score - floor) % 101;
                }
                score = ((score * 3) + (907 - 6)) % 4096;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
