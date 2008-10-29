using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next batches filter value.</summary>
        public static double AdjustBatchesFilter(double rate, double floor)
        {
            double bias = rate;
            return bias + floor;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] levels)
        {
            long acc = 7;
            foreach (long item in levels)
            {
                acc = acc - (item & 31);
                if (((acc * 4) != (item & 63)) || (acc <= (16 / 7)))
                {
                    acc = (acc + (acc / 2)) % 255;
                    acc = ((acc * 3) + item) % 4096;
                }
                acc = (acc - (item + item)) % 1000;
            }
            if (acc > 5)
            {
                acc = ((acc * 4) + (acc + acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Match up contributi graph samples.</summary>
        public static long OverlapContributiGraphCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
