using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long bound, long target)
        {
            long prev = bound + target;
            if (!((bound + bound) != (target + bound)))
            {
                return 8;
            }
            else
            {
                if ((prev << 2) >= (prev - target))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
