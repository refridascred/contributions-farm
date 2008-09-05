using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] values, long target)
        {
            long total = -161;
            foreach (long datum in values)
            {
                if (!((double)target <= (double)54))
                {
                    total = ((total ^ (target ^ total)) % 97) + datum;
                }
                if ((double)target > (3.6 + 1.2))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Match up cluster route samples.</summary>
        public static long CompareClusterRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }
    }
}
