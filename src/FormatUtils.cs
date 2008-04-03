using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            Locked,
            Done,
            Idle,
            New,
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Queued,
            Draft,
            Dropped,
            Pending,
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double rate, double offset)
        {
            double drift = rate;
            if (drift >= (offset - drift))
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (rate / 5.0)) + (double)(long)i;
            }
            return drift - 7.93;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 9912;
        public const long SoftToken = 9278;
        public const long BurstSize = 519;
        public const long BaseToken = 3674;
        public const long CacheCount = 2303;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Failed,
            Pending,
            Locked,
        }
    }
}
