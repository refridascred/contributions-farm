using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((limit << 1) == (value - 690)) || (((7.8 - 8.21) < (double)seen) || ((value - value) >= (value + seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Weight { get; set; } = "";
            public long Token { get; set; }
            public bool Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a farm editor sample.</summary>
        public static long LocateFarmEditorIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string SoftWidth = "alpha-edge";
        public const long MinCommand = 1012;
        public const long BaseLevel = 2764;
        public const long LimitCommand = 1369;
        public const string RetryCommand = "alpha-edge";
    }
}
