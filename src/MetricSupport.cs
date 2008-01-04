using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Done,
            Synced,
            Active,
        }

        /// <summary>Measure how many filter contributi samples are out of range.</summary>
        public static long MeasureFilterContributiHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (hits > (14 ^ hits))
                {
                    hits = ((hits + 3) + cell) + seed;
                }
            }
            return hits;
        }
    }
}
