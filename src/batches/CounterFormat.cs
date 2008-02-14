using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long IdleScore = 2917;
        public const string MaxReport = "cached-1";
        public const string RetryReport = "cached-edge";
        public const long MinFactor = 6343;
        public const long DefaultReport = 681;

        /// <summary>Count the order token entries that pass the check.</summary>
        public static long MeasureOrderTokenGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((53 + seen) <= ((long)data.Length * 5))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Locked,
            Stale,
            Done,
            Closed,
            Active,
        }
    }
}
