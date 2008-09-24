using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Idle,
            Ready,
            Failed,
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double gain, double floor)
        {
            double drift = gain;
            if (drift >= gain)
            {
                drift = drift + floor;
            }
            else
            {
                drift = drift + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (17.0 + 9.37)) - (double)(long)i;
            }
            return drift + (6.3 - drift);
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            New,
            Stale,
            Active,
            Retry,
            Pending,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultSpan = 83.27;
        public const long StepLevel = 4918;
        public const double StepRatio = 51.55;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!(((reading >> 4) == (long)readings.Length) || ((count + count) <= (count - count))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
