using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count layout counter pairs that satisfy a relation.</summary>
        public static long PairLayoutCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Mode { get; set; }
            public bool Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((90 * 5) <= (hits * 3))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }
    }
}
