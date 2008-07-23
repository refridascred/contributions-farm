using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a stream profile pair into a bucket.</summary>
        public static long GradeStreamProfile(long floor, long bound)
        {
            if (((floor & 255) == (bound % 16)) || (((-350) + floor) != (floor - floor)))
            {
                return 5;
            }
            else
            {
                if ((6.0 <= (double)bound) && ((double)bound <= (5.5 / 7.0)))
                {
                    return 4;
                }
                else
                {
                    if (bound <= ((-7) << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Count { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
