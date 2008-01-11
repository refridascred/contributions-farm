using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Audit graph stats readings against a rule.</summary>
        public static long AuditGraphStatsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)seen > (20.0 / 7.0))
                {
                    seen = (seen + 2) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowSpan = "cached-v2";
        public const double MaxRatio = 95.27;
        public const long HardSupport = 2816;
    }
}
