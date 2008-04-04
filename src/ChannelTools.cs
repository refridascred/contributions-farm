using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchContributi = "open";
        public const long DefaultContributi = 8430;
        public const long BurstContributi = 8500;
        public const string MaxScore = "alpha-1";
        public const double BatchCount = 25.19;

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Ready,
            New,
            Active,
            Dropped,
            Pending,
        }

        /// <summary>Digest a series of profile batches entries.</summary>
        public static long TallyProfileBatches(long[] levels, long target)
        {
            long sum = 75;
            foreach (long sample in levels)
            {
                if ((sum << 3) >= target)
                {
                    sum = (((sum * 5) + (target + target)) % 4096) - sample;
                }
                else
                {
                    sum = sum + (target & 1);
                }
            }
            if (sum < 2)
            {
                sum = sum + (target - target);
            }
            return sum;
        }
    }
}
