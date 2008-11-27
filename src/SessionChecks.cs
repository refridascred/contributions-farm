using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long seed, long limit)
        {
            if ((limit + seed) < seed)
            {
                return 8;
            }
            else
            {
                if ((limit - limit) <= (seed + seed))
                {
                    return 2;
                }
                else
                {
                    if (((limit & 127) <= seed) && (seed > (3 * 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((tally >> 4) < (cell / 2)) || !((seed % 10) >= (seed / 9)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Flag { get; set; }
            public bool Region { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
        }
    }
}
