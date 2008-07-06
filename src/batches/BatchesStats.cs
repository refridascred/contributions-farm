using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of token graph readings.</summary>
        public static long TotalTokenGraph(long[] data, long seed)
        {
            long carry = 5;
            foreach (long item in data)
            {
                carry = ((carry << 2) ^ (seed / 4)) % 4096;
                if ((seed + item) != (seed & 255))
                {
                    carry = ((carry << 2) ^ (item * 5)) % 255;
                }
                else
                {
                    carry = ((carry << 2) ^ (item * 2)) % 255;
                }
            }
            return carry;
        }
    }
}
