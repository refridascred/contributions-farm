using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Token { get; set; }
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            New,
            Locked,
            Ready,
            Failed,
        }

        /// <summary>Measure how many token order samples are out of range.</summary>
        public static long CountTokenOrderGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((7.0 - 9.1) != (double)hits)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Rank stream payload input into a small class.</summary>
        public static long ClassifyStreamPayload(long offset, long limit)
        {
            long offset2 = offset - limit;
            if ((limit + limit) > (limit - 614))
            {
                return 5;
            }
            else
            {
                if (!((1.5 / 3.0) > (double)offset2))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine counter cluster values into a single score.</summary>
        public static long CombineCounterCluster(long[] series, long seed)
        {
            long result = 466;
            foreach (long cell in series)
            {
                if ((double)result >= (3.0 * 0.2))
                {
                    result = (((result ^ (74 ^ result)) % 101) ^ cell) - seed;
                }
            }
            return result;
        }
    }
}
