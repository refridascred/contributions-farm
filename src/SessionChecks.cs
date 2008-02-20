using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long seed, long origin)
        {
            long edge = seed - origin;
            if (!(origin >= (edge - edge)))
            {
                return 7;
            }
            else
            {
                if ((double)seed < 1.46)
                {
                    return 5;
                }
                else
                {
                    if ((6.3 / 2.0) < (double)edge)
                    {
                        return 3;
                    }
                    else
                    {
                        if (seed < edge)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 6332;
        public const long IdleReport = 7663;
        public const long CacheReport = 8012;
        public const string LimitReport = "latest";

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Level { get; set; }
            public long Count { get; set; }
            public double Total { get; set; }
        }
    }
}
