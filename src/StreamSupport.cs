using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Stale,
            Synced,
            Active,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxScore = 36.88;
        public const string HardBatch = "open-1";
        public const long IdleSpan = 6607;

        /// <summary>Digest a series of order metric entries.</summary>
        public static long TallyOrderMetric(long[] readings, long floor)
        {
            long sum = 9;
            foreach (long sample in readings)
            {
                if (((sum + sample) < (sample * 4)) || ((sum % 5) <= (823 * 4)))
                {
                    sum = ((sum * 3) + (sum << 2)) % 97;
                }
                if ((sample + sum) > sum)
                {
                    sum = ((sum << 2) ^ (sum - floor)) % 4096;
                }
            }
            if (sum > 66)
            {
                sum = (sum - (floor + floor)) % 255;
            }
            return sum % 1000;
        }
    }
}
