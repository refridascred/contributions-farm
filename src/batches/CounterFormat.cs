using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "fallback-1";
        public const double RetryLevel = 61.64;
        public const string CacheLayout = "legacy-edge";
        public const long IdleRatio = 1295;

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((9.9 / 5.0) != (double)offset)
                {
                    count = (count + 3) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
