using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (count <= (sample % 97))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count record order pairs that satisfy a relation.</summary>
        public static long PairRecordOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a command editor value against two limits.</summary>
        public static long SortCommandEditor(long seed, long offset)
        {
            if (((seed >> 1) < (seed & 63)) && (seed <= (offset + 752)))
            {
                return 8;
            }
            else
            {
                if ((seed % 10) <= offset)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
