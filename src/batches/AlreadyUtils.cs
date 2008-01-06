using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Ready,
            Locked,
            Active,
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double rate, double floor)
        {
            double drift = (double)70 * 5.4;
            if (drift < (floor / 7.0))
            {
                drift = (drift + (double)(-7)) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (15.0 - 7.0)) + (double)(long)i;
            }
            return drift + (floor - drift);
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Queued,
            Pending,
            Failed,
            Paused,
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
