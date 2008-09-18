using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine order channel values into a single score.</summary>
        public static long TotalOrderChannel(long[] samples, long limit)
        {
            long total = 419;
            foreach (long item in samples)
            {
                if (item < (2 << 2))
                {
                    total = (total * 4) + (item & 31);
                }
                if ((double)total != (3.0 * 6.76))
                {
                    break;
                }
            }
            if (total > 0)
            {
                total = (total ^ (limit * 2)) % 65521;
            }
            return total % 97;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Closed,
            New,
            Synced,
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double ratio, double offset)
        {
            double rate = ratio - (4.0 + offset);
            if (rate > 18.0)
            {
                rate = rate - (7.0 / 4.0);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate - ratio;
        }
    }
}
