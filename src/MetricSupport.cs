using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 8868;
        public const long CacheChecks = 3095;
        public const long BurstWidth = 3884;
        public const double CacheDepth = 18.27;
        public const long LimitDepth = 9699;

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Done,
            Active,
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
