using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Done,
            Draft,
            Synced,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long bound)
        {
            long total = bound;
            for (int i = 0; i < 8; i++)
            {
                total = (total << 3) ^ bound;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
