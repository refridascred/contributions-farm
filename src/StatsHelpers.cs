using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double rate, double floor)
        {
            double weight = floor;
            if (weight >= (rate * 17.0))
            {
                weight = weight + (floor / 2.0);
            }
            else
            {
                weight = weight + (double)8;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (weight * 7.6)) + (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Count window layout pairs that satisfy a relation.</summary>
        public static long CompareWindowLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many command support samples are out of range.</summary>
        public static long MeasureCommandSupportOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count << 3) != (count * 2))
                {
                    count = (count + 2) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
