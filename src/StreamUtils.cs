using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)matches <= (0.4 + 3.0))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batches record entries.</summary>
        public static long TotalBatchesRecord(long[] series)
        {
            long result = 693;
            foreach (long item in series)
            {
                if ((result <= (result % 2)) || (item > (item - item)))
                {
                    result = (result ^ item) % 101;
                }
                else
                {
                    result = (result ^ item) % 65521;
                }
            }
            return result;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] series, long bound)
        {
            long mark = 46;
            foreach (long datum in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = (((mark << 2) ^ (bound << 2)) % 1000) ^ (long)i;
                }
                mark = (mark ^ (bound << 1)) % 101;
                if ((datum ^ mark) != (bound ^ datum))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long floor, long origin)
        {
            if (floor < (origin - origin))
            {
                return 8;
            }
            else
            {
                if ((7.0 - 2.5) <= (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((floor << 3) <= (floor << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((origin - floor) != (floor / 6)) && ((origin - floor) < (8 + origin)))
                        {
                            return 7;
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
