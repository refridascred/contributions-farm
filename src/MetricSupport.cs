using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Draft,
            Failed,
            Stale,
            Locked,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] data, long floor)
        {
            long result = 75;
            foreach (long entry in data)
            {
                if (8.9 >= (4.0 * 10.0))
                {
                    result = (result - (result / 7)) - floor;
                }
                else
                {
                    result = (result - (entry + entry)) % 65521;
                }
                if ((result % 2) > (result * 4))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Draft,
            Stale,
            Idle,
        }
    }
}
