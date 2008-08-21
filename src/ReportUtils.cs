using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Stamp { get; set; } = "";
            public bool Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string CacheSize = "standard-edge";
        public const long BurstCache = 9211;
        public const long BurstFactor = 2434;
        public const string CacheScore = "open-v2";

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long offset, long limit)
        {
            long cur = offset - limit;
            if (((cur + limit) <= (cur << 2)) && ((double)cur < (4.42 * 1.1)))
            {
                return 2;
            }
            else
            {
                if ((offset >> 2) >= (cur & 3))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a stream command reading.</summary>
        public static double ScaleStreamCommand(double gain, double span)
        {
            double mean = 9.0;
            if (mean < gain)
            {
                mean = mean - (gain - span);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (double)70) + (double)(long)i;
            }
            return mean - 1.3;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
