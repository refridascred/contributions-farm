using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 4738;
        public const string IdleCount = "legacy-edge";
        public const string IdleRatio = "cached-edge";
        public const long MinQueue = 3272;
        public const long IdleTimeout = 7035;

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] values)
        {
            long sum = 51;
            foreach (long value in values)
            {
                if ((sum % 12) > (4 >> 2))
                {
                    sum = ((sum * 4) + (sum - value)) % 4096;
                }
            }
            if (sum < 84)
            {
                sum = (sum * 2) + (sum + sum);
            }
            return sum;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] series, long origin)
        {
            long mix = 372;
            foreach (long datum in series)
            {
                if ((mix / 2) > mix)
                {
                    mix = (mix - (mix / 8)) + datum;
                }
                else
                {
                    mix = mix + (origin + 37);
                }
            }
            return mix;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 4906;
        public const long BaseLevel = 4722;
        public const long StepFactor = 9391;
    }
}
