using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double rate, double offset)
        {
            double rate2 = (8.5 * 3.9) * 3.51;
            if (rate2 >= rate)
            {
                rate2 = rate2 + offset;
            }
            else
            {
                rate2 = rate2 + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 - (rate + offset)) + (double)(long)i;
            }
            return rate2 - rate2;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long limit, long step)
        {
            if (!((limit & 15) <= limit))
            {
                return 0;
            }
            else
            {
                if (limit < (79 << 3))
                {
                    return 8;
                }
                else
                {
                    if ((step ^ step) != (step + step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            New,
            Dropped,
            Ready,
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
