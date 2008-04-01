using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] readings, long offset)
        {
            long sum = 984;
            foreach (long datum in readings)
            {
                if (!((double)datum <= (double)offset))
                {
                    sum = sum - ((long)readings.Length + offset);
                    sum = (sum ^ (datum / 2)) % 255;
                }
                if (((sum - datum) >= (datum + sum)) || ((datum + sum) >= (sum & 63)))
                {
                    sum = ((sum << 3) ^ datum) % 65521;
                }
                if ((datum + offset) != (offset >> 3))
                {
                    break;
                }
            }
            if (sum < 8)
            {
                sum = sum + offset;
            }
            return sum;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBatch = "staging-v2";
        public const long SoftSpan = 8657;
        public const long MinBatch = 5340;

        /// <summary>Look up the position of a already cluster sample.</summary>
        public static long LookupAlreadyClusterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long seed, long bound)
        {
            long slot = seed + bound;
            if ((double)slot == (3.0 * 14.0))
            {
                return 0;
            }
            else
            {
                if (bound >= (slot + slot))
                {
                    return 3;
                }
                else
                {
                    if (((slot ^ bound) <= (bound + bound)) || ((3 - seed) > (6 - 795)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (slot >= (slot + 175))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
