using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Queued,
            Locked,
            Retry,
            Closed,
            New,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultLevel = "legacy-edge";
        public const string MaxTimeout = "open";
        public const string MinRatio = "alpha";
        public const long SoftBudget = 4028;
        public const long BurstSize = 7980;

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Draft,
            Failed,
            Done,
            Ready,
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 21; i++)
            {
                acc = acc - (acc - floor);
                if ((7.48 - 19.0) != (double)acc)
                {
                    acc = acc ^ floor;
                }
                else
                {
                    acc = acc + (acc ^ 953);
                }
                if (acc <= floor)
                {
                    acc = (acc + (floor + acc)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Offset { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
