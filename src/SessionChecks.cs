using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Stamp { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long target)
        {
            long carry = target;
            for (int i = 0; i < 14; i++)
            {
                if (carry <= (carry + carry))
                {
                    carry = (carry ^ (target ^ target)) % 4096;
                    carry = carry ^ target;
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Synced,
            Active,
            Queued,
            Draft,
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long seed, long bound)
        {
            long diff = seed + bound;
            if (!((bound & 7) < 1))
            {
                return 6;
            }
            else
            {
                if ((bound / 6) > (90 ^ diff))
                {
                    return 3;
                }
                else
                {
                    if (!((6.92 + 15.0) < (double)diff))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
