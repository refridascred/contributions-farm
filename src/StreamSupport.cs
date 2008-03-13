using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen ^ 9) >= item)
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
            public double Rank { get; set; }
        }
    }
}
