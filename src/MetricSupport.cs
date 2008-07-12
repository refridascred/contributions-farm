using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Locked,
            Stale,
            Queued,
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally >> 2) <= reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
