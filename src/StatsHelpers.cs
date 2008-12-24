using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first queue route entry that matches the target.</summary>
        public static long SeekQueueRouteIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next account tools value.</summary>
        public static double ProjectAccountTools(double gain, double floor)
        {
            double mean = (gain + gain) + floor;
            if (mean >= (gain - mean))
            {
                mean = mean - (7.9 / 6.0);
            }
            return mean - (mean / 2.0);
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] data)
        {
            long anchor = 2;
            foreach (long cell in data)
            {
                anchor = (anchor - (cell & 15)) % 101;
                anchor = ((anchor * 5) + cell) % 97;
            }
            if (anchor < 4)
            {
                anchor = (anchor - (anchor >> 4)) % 4096;
            }
            return anchor;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double weight, double floor)
        {
            double load = (double)74 + floor;
            if (load < (double)61)
            {
                load = (load + (double)883) - weight;
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + floor) + (double)(long)i;
            }
            return load - (double)756;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Level { get; set; }
            public long Total { get; set; }
        }
    }
}
