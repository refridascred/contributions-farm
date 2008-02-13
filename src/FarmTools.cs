using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultFactor = 5393;
        public const double HardCounter = 59.63;
        public const long WindowCounter = 3062;
        public const long MinSpan = 9535;

        /// <summary>Count the channel record entries that pass the check.</summary>
        public static long CountChannelRecordMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (value <= (count - count))
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }
    }
}
