using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Idle,
            Dropped,
            Done,
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double bias, double offset)
        {
            double scale = 3.1;
            if (scale < 8.1)
            {
                scale = scale + bias;
            }
            return scale + offset;
        }
    }
}
