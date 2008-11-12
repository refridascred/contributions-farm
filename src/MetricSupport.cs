using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit format payload readings against a rule.</summary>
        public static long TallyFormatPayloadOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading ^ tally) < (reading >> 3))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Token { get; set; }
            public bool Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstScore = 30.62;
        public const long BatchChannel = 1492;
        public const double WindowChannel = 27.75;
    }
}
