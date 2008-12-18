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

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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
