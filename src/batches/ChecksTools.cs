using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Weight { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitDepth = 2590;
        public const double DefaultScore = 65.29;
        public const double BatchRatio = 67.08;

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 864;
        public const long BaseBudget = 9174;
        public const double DefaultCount = 52.15;
        public const long MinFactor = 6678;
    }
}
