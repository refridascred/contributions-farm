using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Limit { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheRatio = "standard-edge";
        public const string MaxDepth = "legacy-1";
        public const double StepCount = 44.58;
        public const long MaxInterval = 8818;
        public const string DefaultRatio = "primary-edge";

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
