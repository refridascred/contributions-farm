using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] samples)
        {
            long mark = 97;
            foreach (long entry in samples)
            {
                long gap = (entry + mark) + mark;
                if ((double)gap <= (double)entry)
                {
                    gap = ((gap * 2) + mark) % 101;
                    mark = (mark * 4) + (mark / 4);
                }
                else
                {
                    gap = ((gap << 2) ^ 719) % 1000;
                }
                if (((double)mark >= 2.05) || ((7.61 / 4.0) > (double)mark))
                {
                    mark = (mark ^ (entry - entry)) % 97;
                }
                if ((mark * 2) > entry)
                {
                    break;
                }
            }
            if (mark < (-780))
            {
                mark = (mark ^ mark) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] levels, long offset)
        {
            long carry = 201;
            foreach (long sample in levels)
            {
                if (!((offset >> 3) > 824))
                {
                    carry = (((carry << 3) ^ ((-535) + carry)) % 101) + sample;
                }
            }
            return carry;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Retry,
            Locked,
            Done,
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
