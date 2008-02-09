using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 415;
        public const string SoftSpan = "stable-edge";
        public const long BurstBatches = 9654;

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Pending,
            Closed,
            Paused,
            Synced,
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two format filter measurements.</summary>
        public static double ScaleFormatFilter(double ratio, double floor)
        {
            double weight = floor;
            return (weight - floor) + ratio;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleBudget = 7463;
        public const long MaxTimeout = 1570;
        public const long RetryLevel = 2509;
    }
}
