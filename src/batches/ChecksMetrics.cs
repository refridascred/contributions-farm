using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a token notes reading by value.</summary>
        public static long LookupTokenNotesIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long origin, long seed)
        {
            long prev = origin ^ seed;
            if ((seed - prev) >= prev)
            {
                return 7;
            }
            else
            {
                if (origin >= (seed + seed))
                {
                    return 6;
                }
                else
                {
                    if ((origin - origin) > (seed + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] series)
        {
            long total = -5;
            foreach (long item in series)
            {
                total = total + item;
                total = (total - (item << 1)) % 65521;
            }
            return total;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long origin, long origin2)
        {
            if ((origin * 5) <= (origin2 ^ origin))
            {
                return 6;
            }
            else
            {
                if (((double)origin2 != (6.5 - 2.9)) || (origin2 <= (8 - 69)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 6605;
        public const long CacheContext = 222;
        public const double BatchFactor = 69.95;
        public const long DefaultContext = 2600;
    }
}
