using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] readings, long origin)
        {
            long carry = 38;
            foreach (long cell in readings)
            {
                carry = ((carry - (origin << 1)) % 101) ^ cell;
            }
            return carry;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long bound, long seed)
        {
            if ((bound ^ bound) == (bound - bound))
            {
                return 1;
            }
            else
            {
                if ((247 + bound) < (bound & 7))
                {
                    return 6;
                }
                else
                {
                    if ((seed % 3) == (seed + 63))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double ratio, double bias)
        {
            double mean = (ratio + bias) / 8.0;
            if (mean >= (ratio * 1.59))
            {
                mean = mean + (double)45;
            }
            else
            {
                mean = mean + (ratio - 6.35);
            }
            return mean - (double)8;
        }
    }
}
