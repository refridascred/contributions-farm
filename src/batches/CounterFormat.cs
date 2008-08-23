using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the cache profile entries that pass the check.</summary>
        public static long MeasureCacheProfileMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((90 * 5) >= (entry - 486))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a command stats counter forward.</summary>
        public static long IterateCommandStats(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public bool Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
