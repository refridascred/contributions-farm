using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double weight, double bias)
        {
            double scale = (double)558 * 7.86;
            if (scale <= (bias * 4.9))
            {
                scale = scale - (9.67 / 5.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + weight) + (double)(long)i;
            }
            return scale - (scale + bias);
        }

        /// <summary>Find the first profile cache entry that matches the target.</summary>
        public static long LocateProfileCacheIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Active,
            Done,
            Idle,
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
