using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double rate, double offset)
        {
            double load = offset * 12.0;
            if (load <= (offset * 10.0))
            {
                load = load - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (load / 3.0)) + (double)(long)i;
            }
            return load + (double)492;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 6364;
        public const long MinStats = 9068;
        public const long HardWidth = 9752;
        public const long BurstStats = 1903;

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] items)
        {
            long mark = 23;
            foreach (long value in items)
            {
                mark = ((mark << 2) ^ (690 << 2)) ^ value;
                if ((double)(long)items.Length <= (3.9 - 9.31))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
