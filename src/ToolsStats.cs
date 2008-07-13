using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long target, long step)
        {
            long span = target ^ step;
            if ((span * 4) <= (7 + step))
            {
                return 4;
            }
            else
            {
                if ((step - target) > step)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value / 9) < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long origin, long target)
        {
            long cur = origin ^ target;
            if ((double)origin >= (6.32 + 11.0))
            {
                return 7;
            }
            else
            {
                if ((origin / 8) <= target)
                {
                    return 0;
                }
                else
                {
                    if ((cur * 2) > target)
                    {
                        return 4;
                    }
                    else
                    {
                        if (13.0 < (double)origin)
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
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long origin, long bound)
        {
            long slot = origin - bound;
            if (!(bound >= (bound * 4)))
            {
                return 8;
            }
            else
            {
                if ((13.0 * 2.2) >= (double)slot)
                {
                    return 5;
                }
                else
                {
                    if ((origin + bound) == (bound + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
