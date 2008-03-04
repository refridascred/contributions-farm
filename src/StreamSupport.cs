using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Locked,
            Stale,
            Failed,
            Idle,
            Done,
        }

        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double ratio, double floor)
        {
            double mean = ratio;
            if (mean < mean)
            {
                mean = (mean + (double)6) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - (double)3;
        }
    }
}
