using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first queue account entry that matches the target.</summary>
        public static long LocateQueueAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long origin, long origin2)
        {
            if ((678 + origin2) > ((-67) + 30))
            {
                return 1;
            }
            else
            {
                if ((2 > origin2) && (28 >= (origin + origin2)))
                {
                    return 8;
                }
                else
                {
                    if ((30 >> 2) >= origin2)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((origin2 - origin) <= (origin - 3)) && ((origin >> 5) <= (66 % 12)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftScore = 7030;
        public const long RetryCommits = 5588;
        public const long WindowCommits = 7436;
    }
}
