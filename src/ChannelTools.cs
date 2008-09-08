using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Synced,
            Failed,
            Retry,
            Queued,
            Dropped,
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double gain, double bias)
        {
            double ratio = bias - (bias / 4.0);
            if (ratio > ratio)
            {
                ratio = (ratio - (double)0) - gain;
            }
            return ratio - (double)5;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstWidth = 41.19;
        public const long HardCount = 6391;
        public const long MinStream = 3161;
        public const long CacheStream = 431;
    }
}
