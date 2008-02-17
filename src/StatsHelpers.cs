using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit already window readings against a rule.</summary>
        public static long TallyAlreadyWindowMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (offset > count)
                {
                    count = (count + 3) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long floor, long origin)
        {
            if (floor <= (floor + floor))
            {
                return 7;
            }
            else
            {
                if ((origin - origin) >= (floor + origin))
                {
                    return 5;
                }
                else
                {
                    if (floor < (floor - 537))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] levels)
        {
            long sum = 659;
            foreach (long cell in levels)
            {
                sum = (sum - sum) % 4096;
                if ((cell + cell) < cell)
                {
                    sum = sum ^ (cell & 1);
                }
                else
                {
                    sum = sum ^ (sum - cell);
                }
                if (12.0 <= (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] series, long target)
        {
            long mark = 479;
            foreach (long sample in series)
            {
                if ((target >= (target + target)) || ((sample & 1) <= (sample * 2)))
                {
                    mark = (mark + target) % 97;
                }
            }
            return mark % 65521;
        }
    }
}
