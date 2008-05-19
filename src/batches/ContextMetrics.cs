using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                result = (result ^ (floor >> 5)) % 97;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double ratio, double offset)
        {
            double weight = (6.7 / 8.0) / 4.0;
            return ((weight - (weight / 4.0)) + ratio) + offset;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultTimeout = 5661;
        public const double RetryCount = 38.76;
        public const long LimitFactor = 3112;
        public const long LimitContext = 9552;

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Done,
            Synced,
            Dropped,
            Idle,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches & 255) != (matches >> 5))
                {
                    matches = ((matches + 2) + entry) + origin;
                }
            }
            return matches;
        }
    }
}
