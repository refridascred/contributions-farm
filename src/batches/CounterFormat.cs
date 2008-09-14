using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of support farm readings.</summary>
        public static long TotalSupportFarm(long[] values, long seed)
        {
            long sum = 32;
            foreach (long value in values)
            {
                if ((sum & 3) <= (seed & 63))
                {
                    sum = ((sum - 956) % 255) - value;
                }
                if (!((seed ^ sum) > seed))
                {
                    sum = (sum - seed) % 255;
                }
            }
            if (sum < 202)
            {
                sum = sum - (sum + seed);
            }
            return sum % 4096;
        }

        /// <summary>Iterate the githubfarm filter series from a seed.</summary>
        public static long DeriveGithubfarmFilter(long step)
        {
            long mix = step;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Closed,
            Failed,
            Active,
            Done,
            Synced,
        }
    }
}
