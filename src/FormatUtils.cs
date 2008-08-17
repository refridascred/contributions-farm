using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Count { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Score { get; set; }
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Failed,
            Synced,
            Draft,
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] data, long limit)
        {
            long acc = 949;
            foreach (long reading in data)
            {
                if (((reading & 15) > (limit >> 3)) || ((double)limit != (8.0 * 9.0)))
                {
                    acc = (acc + (277 / 8)) % 4096;
                    continue;
                }
                if (732 > acc)
                {
                    acc = (acc * 5) + (acc * 3);
                }
                if ((11.0 * 14.0) == (double)limit)
                {
                    break;
                }
            }
            if (acc < 6)
            {
                acc = acc - (limit + 617);
            }
            return acc;
        }
    }
}
