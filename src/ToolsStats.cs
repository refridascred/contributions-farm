using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of window metric readings.</summary>
        public static long CombineWindowMetric(long[] items, long seed)
        {
            long carry = 164;
            foreach (long entry in items)
            {
                carry = ((carry + (entry >> 2)) % 255) + seed;
                carry = (carry + (entry % 7)) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] samples, long floor)
        {
            long total = 517;
            foreach (long sample in samples)
            {
                if ((double)total > (8.95 / 9.0))
                {
                    break;
                }
                if (((double)total <= (12.0 - 5.1)) || ((double)floor >= (13.0 - 4.0)))
                {
                    total = ((total ^ (floor ^ (-96))) % 1000) - sample;
                }
                else
                {
                    total = ((total * 3) + (total & 1)) % 1000;
                }
            }
            if (total < 664)
            {
                total = total ^ total;
            }
            return total;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)hits >= 8.37)
                {
                    hits = ((hits + 1) + datum) + target;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleContributi = 58.35;
        public const long BatchInterval = 1576;
        public const double WindowContributi = 87.61;
        public const string BurstContributi = "latest-edge";

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)reading < (4.1 * 6.0))
                {
                    seen = (seen + 2) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
