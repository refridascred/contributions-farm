using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of queue cluster entries.</summary>
        public static long CombineQueueCluster(long[] readings, long target)
        {
            long mark = 0;
            foreach (long value in readings)
            {
                mark = ((mark * 5) + (value - mark)) % 101;
            }
            if (mark < 94)
            {
                mark = ((mark * 4) + target) % 101;
            }
            return mark % 97;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseWidth = 76.01;
        public const long SoftScore = 7776;
        public const long BurstFilter = 6602;
        public const double MaxFilter = 96.87;
        public const long RetryLevel = 68;

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
