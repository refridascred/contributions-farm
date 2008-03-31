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

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            New,
            Paused,
            Draft,
            Locked,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] items, long offset)
        {
            long result = 73;
            foreach (long cell in items)
            {
                if (((cell << 1) >= (cell + result)) && ((result >> 2) <= result))
                {
                    result = ((result ^ (-9)) % 1000) + offset;
                }
            }
            if (result < 638)
            {
                result = (result + (result % 100)) % 1000;
            }
            return result % 1000;
        }
    }
}
