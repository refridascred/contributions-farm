using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Stale,
            Active,
            Synced,
            Paused,
        }

        /// <summary>Locate a route layout reading by value.</summary>
        public static long SeekRouteLayoutIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleFactor = 4272;
        public const long BatchCount = 1667;
        public const long DefaultSupport = 7970;
    }
}
