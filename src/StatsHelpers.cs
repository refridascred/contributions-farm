using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum << 3) ^ (long)i;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Idle,
            New,
            Queued,
            Locked,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstCounter = 53.81;
        public const long BurstCount = 236;
        public const string RetryCounter = "legacy-1";
        public const long IdleCounter = 538;
        public const string BatchRatio = "cached-edge";

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseScore = 7266;
        public const long RetryEntry = 4675;
        public const string MaxEntry = "cached-v2";
        public const string SoftEntry = "alpha-v2";
    }
}
