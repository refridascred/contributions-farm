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

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] readings)
        {
            long sum = 98;
            foreach (long entry in readings)
            {
                sum = ((sum << 3) ^ (entry >> 2)) % 101;
                if ((entry << 1) < sum)
                {
                    sum = (sum * 4) + (sum + 8);
                }
            }
            if (sum > 371)
            {
                sum = (sum - (sum * 3)) % 97;
            }
            return sum;
        }
    }
}
