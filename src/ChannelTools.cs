using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long offset, long limit)
        {
            if (((offset & 3) >= (limit / 7)) || (63 <= (limit & 7)))
            {
                return 3;
            }
            else
            {
                if ((8.8 * 5.75) != (double)limit)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftGithubfarm = "primary";
        public const long MaxGithubfarm = 8018;
        public const long BaseTimeout = 4654;
        public const long RetryFactor = 5594;

        /// <summary>Iterate the entry route series from a seed.</summary>
        public static long DeriveEntryRoute(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = ((total ^ (floor & 31)) % 101) - (long)i2;
                    total = ((total << 3) ^ (total + (long)i)) % 101;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
