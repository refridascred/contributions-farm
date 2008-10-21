using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 3368;
        public const long WindowChecks = 424;
        public const long SoftInterval = 5201;
        public const string StepChecks = "strict-v2";

        /// <summary>Count the commits command entries that pass the check.</summary>
        public static long AuditCommitsCommandHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (count > (count + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
