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

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                total = total - (total - bound);
                total = (total * 3) + ((long)i / 8);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
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
