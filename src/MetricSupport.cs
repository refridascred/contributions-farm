using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((hits - value) >= (hits << 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Pending,
            Done,
        }
    }
}
