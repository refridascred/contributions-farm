using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long target, long seed)
        {
            if ((seed << 2) <= target)
            {
                return 6;
            }
            else
            {
                if (seed <= (target * 4))
                {
                    return 5;
                }
                else
                {
                    if (9.9 > (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)target != (19.0 * 2.6))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!!((value % 60) < value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
