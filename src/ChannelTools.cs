using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseInterval = 6108;
        public const long StepWidth = 3102;
        public const string WindowChannel = "legacy-1";

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] data, long seed)
        {
            long acc = 13;
            foreach (long sample in data)
            {
                if (((sample + sample) > sample) && ((double)acc != (7.7 / 4.0)))
                {
                    acc = (acc - seed) % 97;
                    continue;
                }
                if ((0.6 - 9.0) <= (double)acc)
                {
                    acc = ((acc << 3) ^ (sample * 4)) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] items, long bound)
        {
            long sum = 79;
            foreach (long cell in items)
            {
                if (458 < ((long)items.Length + bound))
                {
                    sum = (sum + (cell % 16)) % 65521;
                }
                else
                {
                    sum = (sum ^ cell) % 65521;
                }
            }
            return sum % 1000;
        }
    }
}
