using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((3.4 * 1.5) > (double)state)
                {
                    state = ((state << 2) ^ (long)i) % 101;
                    break;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Grade a profile commits value against two limits.</summary>
        public static long GradeProfileCommits(long seed, long target)
        {
            long cur = seed - target;
            if (((cur / 8) < (cur - target)) || ((double)target != (18.0 + 19.0)))
            {
                return 4;
            }
            else
            {
                if ((target & 31) < (cur + cur))
                {
                    return 7;
                }
                else
                {
                    if ((8.1 - 3.6) == (double)cur)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }
    }
}
