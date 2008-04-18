using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 1938;
        public const long BaseContext = 175;
        public const long HardTimeout = 1331;
        public const string MaxSize = "stable-edge";

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Idle,
            Ready,
            Retry,
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinBudget = 6503;
        public const double WindowCluster = 7.88;
        public const double LimitRatio = 81.14;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (matches > ((-41) % 3))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }
    }
}
