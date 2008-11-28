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

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Synced,
            Pending,
            Dropped,
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Label { get; set; }
            public bool Owner { get; set; }
            public long Score { get; set; }
            public string Region { get; set; } = "";
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

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Dropped,
            Paused,
            Queued,
            Failed,
        }
    }
}
