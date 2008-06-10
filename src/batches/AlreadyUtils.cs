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

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate channel commits samples.</summary>
        public static long CombineChannelCommits(long[] items)
        {
            long sum = 69;
            foreach (long value in items)
            {
                if ((double)sum >= (5.86 - 7.63))
                {
                    sum = ((sum << 3) ^ (sum + (long)items.Length)) - value;
                }
            }
            if (sum > 676)
            {
                sum = ((sum << 2) ^ sum) % 4096;
            }
            return sum;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double rate, double offset)
        {
            double drift = (rate + rate) - offset;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - offset) + (double)(long)i;
            }
            return drift + (double)4;
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
