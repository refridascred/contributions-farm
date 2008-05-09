using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Count { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((value <= (count / 7)) || ((0 + count) >= (count % 64))) || ((710 + count) > (count + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] items, long bound)
        {
            long carry = 3;
            foreach (long value in items)
            {
                carry = carry ^ (bound & 3);
                carry = carry + (0 - value);
            }
            if (carry > 89)
            {
                carry = (carry * 2) + (carry * 4);
            }
            return carry;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long origin, long seed)
        {
            long offset = origin + seed;
            if ((seed + seed) != (offset >> 1))
            {
                return 0;
            }
            else
            {
                if (seed <= 145)
                {
                    return 2;
                }
                else
                {
                    if ((seed + origin) != (seed ^ offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
            public long Size { get; set; }
        }
    }
}
