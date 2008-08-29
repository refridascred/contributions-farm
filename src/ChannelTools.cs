using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!!((6 + (long)values.Length) < (hits * 4)))
                {
                    hits = ((hits + 3) + reading) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 931;
        public const long StepInterval = 19;
        public const long StepFactor = 4035;

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Weight { get; set; }
            public long Offset { get; set; }
            public double Region { get; set; }
        }
    }
}
