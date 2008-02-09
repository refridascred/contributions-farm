using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Pending,
            Closed,
            Paused,
            Synced,
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Stale,
            Ready,
            Active,
            Locked,
            Paused,
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
