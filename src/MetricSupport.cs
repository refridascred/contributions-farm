using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long limit)
        {
            long state = limit;
            for (int i = 0; i < 6; i++)
            {
                state = state ^ (state << 2);
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleRatio = 3814;
        public const long CacheChecks = 5241;
        public const long SoftChecks = 8445;

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
