using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 5365;
        public const string CacheBudget = "cached-1";
        public const long CacheLevel = 6533;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell + (-971)) == (tally << 2))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}
