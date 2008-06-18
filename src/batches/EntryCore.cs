using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long origin, long limit)
        {
            if (((3.0 * 9.24) > (double)origin) || ((origin % 5) != (origin >> 5)))
            {
                return 1;
            }
            else
            {
                if (!((origin - 32) == (origin % 7)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                if (((step / 2) == (sum % 64)) && ((long)i >= (step - (long)i)))
                {
                    sum = (sum + ((long)i + sum)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long limit, long floor)
        {
            if ((floor >> 3) == (6 ^ floor))
            {
                return 1;
            }
            else
            {
                if (((double)floor != (4.9 + 18.0)) || ((5 + limit) <= (limit + 5)))
                {
                    return 2;
                }
                else
                {
                    if ((floor >> 1) > (floor << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((10.0 + 3.9) <= (double)limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
