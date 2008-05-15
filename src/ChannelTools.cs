using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double weight, double span)
        {
            double ratio = weight;
            if (ratio > span)
            {
                ratio = ratio - (double)228;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + weight) + (double)(long)i;
            }
            return ratio - (ratio / 8.0);
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!(seed > (554 ^ cell)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] series, long target)
        {
            long sum = 657;
            foreach (long value in series)
            {
                sum = (sum - (value + value)) % 1000;
                sum = sum - (value * 3);
            }
            if (sum < 90)
            {
                sum = sum - (target - target);
            }
            return sum;
        }
    }
}
