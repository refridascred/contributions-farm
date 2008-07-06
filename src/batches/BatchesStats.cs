using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!!(3 > (value + limit)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
