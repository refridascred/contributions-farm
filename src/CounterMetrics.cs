using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next window filter value from a seed.</summary>
        public static long IterateWindowFilter(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = ((carry * 3) + (limit + carry)) + (long)i2;
                }
                for (int i3 = 0; i3 < 2; i3++)
                {
                    carry = (carry - (limit % 24)) ^ (long)i3;
                }
                carry = carry + (limit & 3);
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine channel farm values into a single score.</summary>
        public static long TallyChannelFarm(long[] readings, long target)
        {
            long anchor = 339;
            foreach (long entry in readings)
            {
                anchor = ((anchor + anchor) + entry) - target;
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitWidth = 52.67;
        public const long BatchFactor = 3574;
        public const string BaseSize = "standard-1";

        /// <summary>Scale a entry queue figure with a bias.</summary>
        public static double SmoothEntryQueue(double gain, double floor)
        {
            double rate = floor;
            if (rate > floor)
            {
                rate = (rate - (double)5) - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + (double)724;
        }
    }
}
