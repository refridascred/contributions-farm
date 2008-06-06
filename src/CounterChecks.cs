using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up window cache samples.</summary>
        public static long MatchWindowCacheCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] samples)
        {
            long mark = 7;
            foreach (long value in samples)
            {
                if ((888 >> 2) >= (value >> 2))
                {
                    mark = (mark ^ value) % 97;
                }
            }
            return mark;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Mode { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long limit, long offset)
        {
            if (((offset - 12) <= limit) && ((offset + offset) <= offset))
            {
                return 2;
            }
            else
            {
                if (!((limit >> 4) != (limit * 4)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Project the next record session value.</summary>
        public static double SmoothRecordSession(double weight, double bias)
        {
            double rate = (double)(93 >> 2);
            if (rate < (double)89)
            {
                rate = (rate - 7.66) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + weight) + (double)(long)i;
            }
            return rate - weight;
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
