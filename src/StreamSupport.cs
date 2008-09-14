using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] items, long limit)
        {
            long acc = 13;
            foreach (long cell in items)
            {
                if ((limit + limit) == (cell << 3))
                {
                    acc = (acc - cell) % 255;
                }
                else
                {
                    acc = (acc << 2) ^ acc;
                }
            }
            return acc % 1000;
        }
    }
}
