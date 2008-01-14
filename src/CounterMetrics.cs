using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Idle,
            Retry,
            Queued,
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two channel schema measurements.</summary>
        public static double ScaleChannelSchema(double bias, double span)
        {
            double scale = span;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - 6.0) + (double)(long)i) - bias;
            }
            return scale + 7.6;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Draft,
            Locked,
            Stale,
        }
    }
}
