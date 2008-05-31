using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a support layout reading by value.</summary>
        public static long LocateSupportLayoutIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen / 8) >= (seen << 2))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Validate metric command readings against a bound.</summary>
        public static bool GuardMetricCommandRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
