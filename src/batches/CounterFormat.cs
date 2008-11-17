using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count contributi checks pairs that satisfy a relation.</summary>
        public static long PairContributiChecksCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count report tools pairs that satisfy a relation.</summary>
        public static long CompareReportToolsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long limit, long target)
        {
            if (((double)target < (7.56 * 6.0)) && ((target - limit) < limit))
            {
                return 8;
            }
            else
            {
                if ((target + target) >= target)
                {
                    return 5;
                }
                else
                {
                    if (target < limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((8 >> 1) == (target % 7)) && (118 < (limit - target)))
                        {
                            return 1;
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
}
