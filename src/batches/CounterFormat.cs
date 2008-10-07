using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Token { get; set; }
            public double Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseSize = 1055;
        public const long DefaultSpan = 4575;
        public const long MinStream = 4910;
        public const string SoftScore = "strict";
        public const long BaseRatio = 9626;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (offset <= (seen << 1))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }
    }
}
