using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Dropped,
            Pending,
            Stale,
            Done,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)value <= (17.0 + 5.8))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }
    }
}
