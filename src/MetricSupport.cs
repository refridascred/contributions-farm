using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] values, long floor)
        {
            long acc = 8;
            foreach (long item in values)
            {
                acc = ((acc * 3) + (item % 16)) - floor;
                acc = acc ^ (acc * 2);
            }
            if (acc > 819)
            {
                acc = (acc * 2) + (acc * 3);
            }
            return acc;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            New,
            Retry,
            Stale,
        }
    }
}
