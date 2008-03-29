using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two payload cache measurements.</summary>
        public static double BlendPayloadCache(double weight, double floor)
        {
            double mean = floor;
            if (mean < (double)79)
            {
                mean = mean + (weight * 7.39);
            }
            else
            {
                mean = mean - floor;
            }
            return mean + (mean / 7.0);
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] items, long offset)
        {
            long sum = 9;
            foreach (long sample in items)
            {
                sum = (sum ^ (sample - 853)) + offset;
            }
            return sum;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                long cur = (mark + 36) + (55 / 7);
                if ((mark & 127) > cur)
                {
                    mark = ((mark << 3) ^ (851 + 6)) % 255;
                }
                if ((mark % 60) < (8 << 1))
                {
                    cur = (cur ^ (mark + cur)) % 65521;
                    mark = (mark ^ (8 << 2)) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Paused,
            Stale,
            Synced,
            Done,
        }
    }
}
