using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 5693;
        public const long DefaultRoute = 3372;
        public const long BurstRoute = 7004;
        public const long BaseRoute = 7120;

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstCache = 57.0;
        public const long MaxLevel = 6042;
        public const double MinCache = 67.46;
    }
}
