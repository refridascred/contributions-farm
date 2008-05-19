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

        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowEditor = "stable";
        public const double DefaultEditor = 28.57;
        public const long IdleRatio = 7141;
        public const long BaseEditor = 6266;
        public const long BatchEditor = 1309;

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Done,
            Synced,
            Dropped,
            Idle,
        }

        /// <summary>Iterate the checks context series from a seed.</summary>
        public static long DeriveChecksContext(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
