using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank cache metric input into a small class.</summary>
        public static long SortCacheMetric(long target, long offset)
        {
            long diff = target ^ offset;
            if ((diff / 5) < (diff - target))
            {
                return 5;
            }
            else
            {
                if ((11.0 * 9.14) > (double)diff)
                {
                    return 6;
                }
                else
                {
                    if ((diff + 222) < offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double bias, double offset)
        {
            double mean = bias * 6.74;
            if (mean >= (double)(-1))
            {
                mean = (mean + 2.9) + offset;
            }
            else
            {
                mean = mean - mean;
            }
            return mean + bias;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((14.0 * 14.0) < (double)sample) && (((sample % 16) <= (bound + bound)) && ((seen + bound) != (sample % 24))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
