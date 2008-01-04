using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a cluster farm value against two limits.</summary>
        public static long SortClusterFarm(long offset, long limit)
        {
            if (3.0 <= (double)offset)
            {
                return 5;
            }
            else
            {
                if ((offset >> 3) <= (limit + limit))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
