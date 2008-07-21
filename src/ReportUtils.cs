using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((1.4 + 8.44) != (double)limit))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
            public long Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Failed,
            Done,
            Locked,
            Pending,
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Score { get; set; }
            public double Stamp { get; set; }
            public bool Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long bound, long limit)
        {
            if ((limit + bound) > (limit - limit))
            {
                return 4;
            }
            else
            {
                if ((limit + bound) < (7 + limit))
                {
                    return 6;
                }
                else
                {
                    if ((194 >> 3) > (bound - 382))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit / 3) != (bound ^ limit))
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
        }
    }
}
