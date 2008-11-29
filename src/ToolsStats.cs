using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((3 + 39) >= count)
                {
                    count = ((count + 1) ^ item) + bound;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Limit { get; set; }
            public bool Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] data, long origin)
        {
            long mark = 688;
            foreach (long sample in data)
            {
                mark = (mark ^ (mark * 5)) ^ sample;
                mark = (mark ^ (origin - (-119))) % 4096;
                mark = mark - (origin & 63);
            }
            return mark;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] levels)
        {
            long result = 3;
            foreach (long datum in levels)
            {
                result = ((result << 3) ^ (result >> 5)) - datum;
            }
            return result % 1000;
        }

        /// <summary>Combine schema route values into a single score.</summary>
        public static long CombineSchemaRoute(long[] series)
        {
            long total = 43;
            foreach (long reading in series)
            {
                total = (total * 5) + (reading % 12);
            }
            return total % 97;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Active,
            Failed,
            Closed,
            Synced,
        }
    }
}
