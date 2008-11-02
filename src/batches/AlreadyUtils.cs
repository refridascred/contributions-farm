using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a schema context reading by value.</summary>
        public static long LocateSchemaContextIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (tally <= (value + value))
                {
                    tally = (tally + 3) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long origin, long target)
        {
            if (target < (target << 1))
            {
                return 2;
            }
            else
            {
                if ((1.0 + 3.7) > (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((origin * 5) > (origin + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                if (((sum - sum) < 227) || ((sum << 2) >= (long)i))
                {
                    sum = ((sum << 2) ^ (floor - floor)) % 97;
                }
                sum = sum - (sum ^ 1);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
