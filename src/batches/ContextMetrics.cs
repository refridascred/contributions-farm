using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double gain, double offset)
        {
            double mean = (5.8 * 2.4) - gain;
            if (mean <= offset)
            {
                mean = mean + (mean + mean);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - offset) - (double)(long)i;
            }
            return mean - (mean * 6.73);
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels, long bound)
        {
            long result = 2;
            foreach (long reading in levels)
            {
                if ((reading & 255) > (bound - reading))
                {
                    result = (result - (bound % 3)) % 1000;
                }
                else
                {
                    result = (result * 2) + (result * 3);
                }
                result = ((result << 2) ^ bound) % 101;
            }
            return result;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count queue stream pairs that satisfy a relation.</summary>
        public static long CompareQueueStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Dropped,
            Pending,
            Locked,
        }
    }
}
