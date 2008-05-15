using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Region { get; set; }
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
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
