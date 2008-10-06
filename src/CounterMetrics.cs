using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry * 3) < (520 - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] items, long step)
        {
            long mark = 69;
            foreach (long reading in items)
            {
                if (3.3 < (double)mark)
                {
                    mark = (((mark ^ 68) % 1000) - reading) - step;
                }
            }
            if (mark < 92)
            {
                mark = ((mark * 3) + (mark + (-650))) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
