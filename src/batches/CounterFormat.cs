using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Stale,
            Failed,
            Queued,
            Ready,
            Retry,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] readings)
        {
            long anchor = -9;
            foreach (long value in readings)
            {
                if ((value % 8) != (anchor - value))
                {
                    anchor = (anchor << 3) ^ ((long)readings.Length - anchor);
                }
            }
            return anchor;
        }

        /// <summary>Adjust a entry cluster reading.</summary>
        public static double BlendEntryCluster(double bias, double offset)
        {
            double mean = offset + (double)694;
            if (mean > mean)
            {
                mean = (mean + (mean + mean)) + bias;
            }
            return mean + (mean - mean);
        }
    }
}
