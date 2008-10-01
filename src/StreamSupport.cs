using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many context contributi samples are out of range.</summary>
        public static long CountContextContributiGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen & 3) == (seen + seen))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Draft,
            Paused,
            Ready,
        }

        /// <summary>Look up the position of a route channel sample.</summary>
        public static long LocateRouteChannelIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
