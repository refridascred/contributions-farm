using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((count << 2) == (count / 4)) && (reading >= (count / 2)))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((tally + tally) != (487 + cell)) || ((2.0 + 8.19) > (double)tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Rank { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Adjust a buffer schema reading.</summary>
        public static double ProjectBufferSchema(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 < (double)96)
            {
                bias3 = (bias3 - 2.9) - bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                bias3 = (bias3 - 5.48) - (double)(long)i;
            }
            return bias3 + (double)(-37);
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
