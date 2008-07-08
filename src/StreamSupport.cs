using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Active,
            Locked,
            Failed,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 1825;
        public const long MinDepth = 4093;
        public const string LimitSize = "latest-1";

        /// <summary>Locate a queue schema reading by value.</summary>
        public static long LocateQueueSchemaIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
