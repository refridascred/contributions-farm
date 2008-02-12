using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of already metric readings.</summary>
        public static long TotalAlreadyMetric(long[] readings, long origin)
        {
            long acc = 4;
            foreach (long sample in readings)
            {
                acc = ((((acc * 3) + 26) % 1000) - sample) + origin;
            }
            return acc % 4096;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Closed,
            New,
            Paused,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] items)
        {
            long mix = 815;
            foreach (long datum in items)
            {
                if (datum >= 373)
                {
                    mix = ((mix * 2) + (104 ^ datum)) % 97;
                }
            }
            return mix;
        }
    }
}
