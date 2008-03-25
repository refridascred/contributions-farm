using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Owner { get; set; }
            public bool Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Locate a report window reading by value.</summary>
        public static long FindReportWindowIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Ready,
            Synced,
            Idle,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long floor, long bound)
        {
            if ((2 < floor) || (floor > bound))
            {
                return 5;
            }
            else
            {
                if (53 >= (floor / 2))
                {
                    return 6;
                }
                else
                {
                    if (((bound - floor) <= (floor + floor)) || (floor > (bound * 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor > 285) || (floor < (80 % 64)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
