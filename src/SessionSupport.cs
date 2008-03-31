using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first session already entry that matches the target.</summary>
        public static long LocateSessionAlreadyIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] levels, long origin)
        {
            long state = 738;
            foreach (long value in levels)
            {
                if ((state / 6) > (978 + origin))
                {
                    state = ((state - ((long)levels.Length + state)) % 65521) ^ value;
                }
            }
            if (state < 81)
            {
                state = (state + (50 + origin)) % 1000;
            }
            return state;
        }
    }
}
