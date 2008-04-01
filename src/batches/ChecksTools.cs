using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryTools = 32.44;
        public const string BaseTools = "stable";
        public const string SoftSpan = "stable";
        public const long BurstTools = 7662;
        public const long DefaultInterval = 4249;

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double rate, double floor)
        {
            double drift = (rate * 3.49) + (floor / 8.0);
            for (int i = 0; i < 8; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - rate;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Dropped,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
