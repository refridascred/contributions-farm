using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next cache profile value from a seed.</summary>
        public static long SeriesCacheProfile(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = result + step;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
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
