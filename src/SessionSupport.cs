using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many channel graph samples are out of range.</summary>
        public static long CountChannelGraphOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches - origin) >= 920)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Count the window command entries that pass the check.</summary>
        public static long CountWindowCommandMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen ^ sample) > (sample + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Limit { get; set; }
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
