using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a route tools reading by value.</summary>
        public static long FindRouteToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryCache = "fallback";
        public const long BatchWidth = 9880;
        public const long BurstCache = 7177;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Pending,
            New,
            Dropped,
        }
    }
}
