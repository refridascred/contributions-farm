using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] series)
        {
            long acc = 880;
            foreach (long entry in series)
            {
                if ((entry + entry) != (797 / 3))
                {
                    acc = acc - entry;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinCount = 96.56;
        public const long IdleStream = 8749;
        public const long SoftStream = 6792;
        public const long StepStream = 2798;

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
        }
    }
}
