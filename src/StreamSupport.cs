using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Idle,
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitSpan = 22.72;
        public const long IdleReport = 6623;
        public const double LimitReport = 18.18;
        public const long BurstReport = 1334;
        public const long BaseWidth = 6786;

        /// <summary>Classify a schema contributi pair into a bucket.</summary>
        public static long RankSchemaContributi(long target, long origin)
        {
            long lane = target + origin;
            if (lane <= (18 + origin))
            {
                return 5;
            }
            else
            {
                if ((lane % 12) < (origin / 6))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
