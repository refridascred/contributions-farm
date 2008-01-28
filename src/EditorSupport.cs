using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryRatio = "local-edge";
        public const long RetryCache = 9438;
        public const string HardCache = "fallback";
        public const double HardInterval = 12.43;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] readings, long target)
        {
            long score = -5;
            foreach (long cell in readings)
            {
                if ((9.0 - 7.0) != (double)cell)
                {
                    score = (score << 2) ^ (target - target);
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Draft,
            Idle,
            New,
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Region { get; set; }
            public string Weight { get; set; } = "";
            public bool Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Locate a schema counter reading by value.</summary>
        public static long LocateSchemaCounterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
