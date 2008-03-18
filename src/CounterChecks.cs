using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 5903;
        public const long CacheChannel = 334;
        public const double IdleChannel = 90.71;

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 797;
        public const long MaxEntry = 1353;
        public const long MinSize = 2347;
        public const long RetryEntry = 1429;

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long origin, long target)
        {
            if (origin < (target / 8))
            {
                return 5;
            }
            else
            {
                if (((double)target == (3.0 / 4.0)) && ((target + origin) <= target))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
