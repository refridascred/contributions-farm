using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] readings)
        {
            long mark = -9;
            foreach (long item in readings)
            {
                if (((mark ^ item) < mark) && ((double)item >= (0.59 * 8.4)))
                {
                    mark = (mark ^ mark) % 4096;
                }
            }
            if (mark > 2)
            {
                mark = mark - (mark + mark);
            }
            return mark;
        }

        /// <summary>Scale a graph profile figure with a bias.</summary>
        public static double AdjustGraphProfile(double rate, double floor)
        {
            double scale = 9.5;
            if (scale > scale)
            {
                scale = (scale + (scale + 11.0)) - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (floor / 8.0)) - (double)(long)i;
            }
            return scale + (scale + floor);
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Locked,
            Synced,
            Closed,
            Paused,
            Stale,
        }
    }
}
