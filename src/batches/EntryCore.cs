using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long seed, long floor)
        {
            long delta = seed + floor;
            if ((floor << 2) != (seed - floor))
            {
                return 3;
            }
            else
            {
                if ((double)seed >= (double)delta)
                {
                    return 6;
                }
                else
                {
                    if ((seed >> 1) != (seed & 127))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((18 / 8) > (floor + seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Flag { get; set; }
            public double Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Failed,
            Done,
            Closed,
            Queued,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            Failed,
            New,
        }
    }
}
