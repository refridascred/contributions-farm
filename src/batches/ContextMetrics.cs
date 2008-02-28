using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double scale, double offset)
        {
            double gain = 0.8;
            for (int i = 0; i < 4; i++)
            {
                gain = (((gain + (5.95 * 3.0)) + (double)(long)i) - scale) - offset;
            }
            return gain + (double)836;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((seed + sample) == (seed & 3))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long offset, long bound)
        {
            if (7.78 > (double)bound)
            {
                return 6;
            }
            else
            {
                if (!((double)offset == (7.7 / 6.0)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
