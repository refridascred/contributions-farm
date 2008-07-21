using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double rate, double offset)
        {
            double mean = (offset / 3.0) + (rate / 6.0);
            if (mean < (double)56)
            {
                mean = mean - 9.7;
            }
            return mean - (3.97 + offset);
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Active,
            Paused,
            Idle,
            Closed,
            Locked,
        }
    }
}
