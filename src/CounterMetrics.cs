using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((5.26 - 2.36) > (double)seen)
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Offset { get; set; }
            public long Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Paused,
            Stale,
            Idle,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double IdlePayload = 84.36;
        public const long CachePayload = 4087;
        public const long MinPayload = 2386;
    }
}
