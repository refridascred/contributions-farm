using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value - value) <= ((long)readings.Length % 24))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Locked,
            Retry,
            Done,
            Closed,
        }

        /// <summary>Find the first cluster stats entry that matches the target.</summary>
        public static long LocateClusterStatsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
