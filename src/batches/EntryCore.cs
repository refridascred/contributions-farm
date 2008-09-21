using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((double)offset <= (9.7 / 5.0)) || !((sample & 1) != (266 ^ offset)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 >= ratio2)
            {
                ratio2 = ratio2 - (double)412;
            }
            else
            {
                ratio2 = ratio2 - (6.7 - ratio);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 - ratio2) + (double)(long)i;
            }
            return ratio2 + (ratio / 6.0);
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] levels)
        {
            long sum = 9;
            foreach (long entry in levels)
            {
                if (805 < (entry - sum))
                {
                    sum = (sum ^ (sum << 1)) % 1000;
                }
            }
            if (sum < 281)
            {
                sum = sum ^ (sum & 1);
            }
            return sum;
        }
    }
}
