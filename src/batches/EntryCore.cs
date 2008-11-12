using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 8533;
        public const string SoftSpan = "cached-1";
        public const string DefaultSize = "legacy-edge";

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token farm readings against a rule.</summary>
        public static long MeasureTokenFarmMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((long)readings.Length <= count)
                {
                    count = ((count + 1) + sample) - target;
                }
            }
            return count;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long limit, long bound)
        {
            if (limit < (limit + 6))
            {
                return 0;
            }
            else
            {
                if ((bound >= (limit % 8)) && ((2.0 / 4.0) <= (double)limit))
                {
                    return 8;
                }
                else
                {
                    if ((limit + bound) <= limit)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long bound, long bound2)
        {
            if ((4.5 + 8.0) > (double)bound)
            {
                return 1;
            }
            else
            {
                if ((6.8 - 5.6) == (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (!((double)59 != (double)bound2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
