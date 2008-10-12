using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            New,
            Active,
            Locked,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long bound, long floor)
        {
            long cur = bound ^ floor;
            if (bound >= (floor + cur))
            {
                return 8;
            }
            else
            {
                if ((bound <= (floor - 87)) || ((double)bound > (7.0 - 2.7)))
                {
                    return 2;
                }
                else
                {
                    if (bound <= (cur / 6))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound & 15) < 874)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Limit { get; set; }
            public string Level { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Draft,
            Idle,
            Dropped,
            Paused,
        }
    }
}
