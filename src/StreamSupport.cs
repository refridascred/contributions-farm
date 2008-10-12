using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] readings)
        {
            long sum = 71;
            foreach (long reading in readings)
            {
                if (!(((908 + sum) == (6 / 9)) && (reading <= (sum / 2))))
                {
                    sum = (sum - (sum * 4)) % 65521;
                }
                sum = (sum << 2) ^ sum;
                sum = sum + (sum + (-166));
            }
            return sum;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route cache input into a small class.</summary>
        public static long SortRouteCache(long limit, long offset)
        {
            long delta = limit - offset;
            if ((delta & 31) >= (delta - delta))
            {
                return 2;
            }
            else
            {
                if (limit <= (delta + 4))
                {
                    return 8;
                }
                else
                {
                    if (offset > (offset % 12))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit >= (delta + delta)) && ((double)limit >= (double)882))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
