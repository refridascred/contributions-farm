using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Mode { get; set; }
            public double Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxLevel = 524;
        public const long BurstEntry = 4052;
        public const long MinEntry = 2776;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((reading & 15) <= (reading + reading)))
                {
                    seen = (seen + 1) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
