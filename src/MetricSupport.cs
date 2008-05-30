using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Idle,
            New,
            Pending,
        }

        /// <summary>Match up cluster entry samples.</summary>
        public static long PairClusterEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
