using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 27;
        public const double DefaultNotes = 5.43;
        public const long WindowNotes = 1103;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 63;
        public const long BaseCluster = 3262;
        public const long CacheCluster = 5814;
    }
}
