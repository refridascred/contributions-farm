using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count << 3) < (117 / 3))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] data)
        {
            long carry = 418;
            foreach (long item in data)
            {
                carry = carry ^ (item * 2);
                if ((4 & 255) > (item ^ carry))
                {
                    break;
                }
            }
            if (carry > 463)
            {
                carry = carry ^ (carry - carry);
            }
            return carry;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Limit { get; set; }
            public bool Region { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }
    }
}
