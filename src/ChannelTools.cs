using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Active,
            Failed,
            Pending,
            Closed,
        }

        /// <summary>Audit editor farm readings against a rule.</summary>
        public static long CountEditorFarmHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count >> 1) > item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
