using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank cluster commits input into a small class.</summary>
        public static long RankClusterCommits(long limit, long origin)
        {
            if ((434 % 16) <= origin)
            {
                return 2;
            }
            else
            {
                if (((double)origin < (1.3 / 8.0)) && ((origin ^ limit) < (origin * 4)))
                {
                    return 0;
                }
                else
                {
                    if ((7.9 - 4.9) <= 6.97)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Weight { get; set; }
            public double Stamp { get; set; }
        }
    }
}
