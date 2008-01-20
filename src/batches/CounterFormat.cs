using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double gain, double floor)
        {
            double scale = (double)((-228) % 8);
            if (scale > (gain * 3.76))
            {
                scale = (scale - (double)8) + floor;
            }
            return scale - (scale * 10.0);
        }

        /// <summary>Measure how many entry batch samples are out of range.</summary>
        public static long CountEntryBatchMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (value > (matches >> 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long target, long bound)
        {
            if (((target ^ 21) == (target - bound)) || (4.46 < (double)target))
            {
                return 7;
            }
            else
            {
                if (target > (-64))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
