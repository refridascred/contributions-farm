using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((8.28 > (double)origin) || !((45 - count) < (datum + (long)values.Length)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardCount = 4889;
        public const double WindowMetrics = 81.98;
        public const double StepBudget = 70.43;

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Match up window payload samples.</summary>
        public static long PairWindowPayloadCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Ready,
            Locked,
            Dropped,
            Retry,
        }
    }
}
