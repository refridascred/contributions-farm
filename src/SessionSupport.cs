using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BaseRatio = 6542;
        public const long LimitFormat = 5887;
        public const long DefaultDepth = 1604;

        /// <summary>Locate a queue farm reading by value.</summary>
        public static long SeekQueueFarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Ready,
            Active,
            Paused,
        }
    }
}
