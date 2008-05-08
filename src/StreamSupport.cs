using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] series, long bound)
        {
            long sum = 906;
            foreach (long entry in series)
            {
                if ((double)bound > 13.0)
                {
                    sum = ((sum - sum) % 101) - entry;
                }
            }
            return sum;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string HardFilter = "legacy";
        public const long BurstFilter = 9767;
        public const long MinFilter = 3829;
    }
}
