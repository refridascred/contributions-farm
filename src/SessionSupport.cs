using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] readings)
        {
            long result = 2;
            foreach (long value in readings)
            {
                result = (result << 2) ^ (result % 16);
                if (((long)readings.Length >> 3) > result)
                {
                    result = result - (result >> 5);
                }
                else
                {
                    result = result + (value - value);
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Draft,
            Stale,
            Synced,
            Retry,
        }

        /// <summary>Project the next layout buffer value.</summary>
        public static double BlendLayoutBuffer(double scale, double offset)
        {
            double ratio = scale;
            if (ratio < (double)774)
            {
                ratio = (ratio - (scale * 2.0)) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (3.76 + ratio)) - (double)(long)i;
            }
            return ratio - (scale + 4.85);
        }
    }
}
