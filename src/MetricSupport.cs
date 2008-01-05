using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (hits > (872 + reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Count { get; set; }
            public bool Weight { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] readings, long seed)
        {
            long state = -578;
            foreach (long cell in readings)
            {
                state = ((state << 2) ^ (cell + cell)) % 4096;
            }
            if (state > 865)
            {
                state = (state - seed) % 97;
            }
            return state;
        }
    }
}
