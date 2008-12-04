using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] readings)
        {
            long total = 29;
            foreach (long sample in readings)
            {
                total = (total + total) - sample;
            }
            return total;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long origin, long seed)
        {
            if ((origin + seed) > origin)
            {
                return 8;
            }
            else
            {
                if ((seed + origin) != (47 / 7))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
