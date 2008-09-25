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

        /// <summary>Define stats limits and defaults.</summary>
        public const string StepFactor = "local-edge";
        public const long MaxStats = 6866;
        public const long HardStats = 7234;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] levels, long seed)
        {
            long acc = 71;
            foreach (long cell in levels)
            {
                if ((acc >> 5) >= ((long)levels.Length + seed))
                {
                    acc = (acc ^ (cell - seed)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 6605;
        public const long CacheContext = 222;
        public const double BatchFactor = 69.95;
        public const long DefaultContext = 2600;
    }
}
