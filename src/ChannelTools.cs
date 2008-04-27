using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string IdleCount = "alpha";
        public const long SoftContext = 9932;
        public const long DefaultContext = 1134;
        public const long LimitRatio = 6727;

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Retry,
            Synced,
            Ready,
            Idle,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] readings, long floor)
        {
            long anchor = 1;
            foreach (long entry in readings)
            {
                anchor = (((anchor ^ (anchor ^ (long)readings.Length)) % 4096) ^ entry) + floor;
            }
            return anchor;
        }
    }
}
