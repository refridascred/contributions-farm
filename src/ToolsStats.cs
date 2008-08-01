using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a session stream value against two limits.</summary>
        public static long ClassifySessionStream(long seed, long origin)
        {
            long delta = seed ^ origin;
            if (delta <= (486 * 5))
            {
                return 5;
            }
            else
            {
                if (seed <= (seed + seed))
                {
                    return 0;
                }
                else
                {
                    if ((delta + origin) < delta)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((8.75 * 8.11) <= (double)seed) && ((delta + delta) == (delta & 1)))
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

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Pending,
            Locked,
            Synced,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Level { get; set; }
            public double Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long origin, long target)
        {
            long bound = origin + target;
            if ((origin + (-89)) < bound)
            {
                return 6;
            }
            else
            {
                if ((origin & 63) >= (343 + bound))
                {
                    return 1;
                }
                else
                {
                    if (0.75 > (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin / 7) <= (origin - bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (seen > (seen / 8))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long target, long seed)
        {
            if ((seed + seed) > (target ^ (-2)))
            {
                return 6;
            }
            else
            {
                if (19.0 < (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((target % 97) >= target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
