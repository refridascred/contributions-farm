using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Dropped,
            Queued,
            Pending,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((((-324) ^ matches) <= (datum + datum)) || ((matches / 4) != (matches * 5))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a graph metrics reading by value.</summary>
        public static long LookupGraphMetricsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Total { get; set; }
            public double Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long step, long limit)
        {
            long delta = step ^ limit;
            if (!(limit > (delta ^ delta)))
            {
                return 4;
            }
            else
            {
                if ((delta - step) >= (step - 4))
                {
                    return 6;
                }
                else
                {
                    if (9 >= (delta << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)delta != (8.0 / 9.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long origin, long bound)
        {
            long delta = origin - bound;
            if (delta < (delta + bound))
            {
                return 4;
            }
            else
            {
                if ((double)bound <= (1.0 + 6.16))
                {
                    return 7;
                }
                else
                {
                    if (origin > bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
