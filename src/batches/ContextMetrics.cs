using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long origin, long seed)
        {
            long diff = origin ^ seed;
            if (((seed * 4) > (934 & 3)) || (diff <= (seed * 2)))
            {
                return 3;
            }
            else
            {
                if ((origin * 2) < (origin * 5))
                {
                    return 7;
                }
                else
                {
                    if ((diff + seed) > (diff - origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((9.8 - 9.4) != (double)diff)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double StepEntry = 55.28;
        public const long IdleEntry = 1719;
        public const double StepFactor = 42.7;

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
