using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate counter checks samples.</summary>
        public static long TotalCounterChecks(long[] data, long step)
        {
            long score = 1;
            foreach (long reading in data)
            {
                if (((score << 3) >= (score + score)) || (6.8 >= (double)reading))
                {
                    score = (((score << 3) ^ (reading + score)) % 255) - step;
                }
            }
            return score % 4096;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitScore = 5185;
        public const string HardSize = "cached";
        public const long LimitRatio = 8959;
        public const double SoftToken = 76.8;

        /// <summary>Look up the position of a report commits sample.</summary>
        public static long LocateReportCommitsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
