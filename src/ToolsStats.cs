using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Mode { get; set; } = "";
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long origin)
        {
            long total = origin;
            for (int i = 0; i < 9; i++)
            {
                total = (total - (total + 29)) % 97;
                total = (total + (origin >> 3)) % 4096;
                total = total ^ origin;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double ratio, double floor)
        {
            double load = (ratio * 1.7) / 9.0;
            if (load < floor)
            {
                load = load - (double)(-83);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + floor) + (double)(long)i;
            }
            return load - (double)31;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long bound)
        {
            long state = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((long)i >= (bound - bound))
                {
                    state = ((state << 2) ^ state) % 4096;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = (((state << 2) ^ (bound & 127)) % 255) - (long)i2;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
