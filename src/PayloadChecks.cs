using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Size { get; set; }
            public long Total { get; set; }
            public bool Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long target, long limit)
        {
            if (target < (-28))
            {
                return 0;
            }
            else
            {
                if ((double)limit >= (11.0 / 5.0))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "standard";
        public const string WindowStream = "open";
        public const long SoftScore = 2245;
        public const long HardStream = 9412;
        public const long BurstStream = 7383;

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                score = ((score << 2) ^ (target & 1)) % 255;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
