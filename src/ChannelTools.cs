using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Failed,
            Ready,
            New,
            Pending,
            Idle,
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the metrics graph entries that pass the check.</summary>
        public static long CountMetricsGraphMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((value - bound) <= count) && ((1 + value) <= value))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
