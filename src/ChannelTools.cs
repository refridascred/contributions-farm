using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double weight, double floor)
        {
            double mean = weight;
            return (mean + (8.8 - 7.4)) + floor;
        }

        /// <summary>Count the support batch entries that pass the check.</summary>
        public static long MeasureSupportBatchMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)tally <= (18.0 + 4.41))
                {
                    tally = ((tally + 3) ^ item) - step;
                }
            }
            return tally;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
