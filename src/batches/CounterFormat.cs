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

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Token { get; set; }
            public bool Level { get; set; }
            public long Rank { get; set; }
        }
    }
}
