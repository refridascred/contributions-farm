using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit batch batches readings against a rule.</summary>
        public static long TallyBatchBatchesHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((item - hits) > (item >> 5)) || ((double)hits == (9.2 / 9.0)))
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
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

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Score { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
            public bool Mode { get; set; }
        }
    }
}
