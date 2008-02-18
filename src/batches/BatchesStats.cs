using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] readings, long offset)
        {
            long result = 3;
            foreach (long reading in readings)
            {
                if (((result & 127) >= (result % 5)) || ((double)result >= (17.0 * 4.5)))
                {
                    result = ((result + (result + 9)) + reading) + offset;
                }
            }
            return result;
        }

        /// <summary>Measure how many commits cache samples are out of range.</summary>
        public static long AuditCommitsCacheMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length - count) > (sample * 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a stream stats sample.</summary>
        public static long LocateStreamStatsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Offset { get; set; }
            public long Owner { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
