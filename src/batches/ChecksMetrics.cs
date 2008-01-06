using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] series)
        {
            long mark = 218;
            foreach (long sample in series)
            {
                if ((sample + sample) > (sample + mark))
                {
                    mark = (mark ^ ((-8) / 2)) % 101;
                }
                else
                {
                    mark = ((mark * 4) + (mark + sample)) % 65521;
                }
            }
            if (mark > 540)
            {
                mark = (mark - mark) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value - 73) != (value + tally))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading ^ reading) < hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a layout window value against two limits.</summary>
        public static long ClassifyLayoutWindow(long offset, long step)
        {
            if (((double)offset < (9.66 - 3.33)) && (step < (offset ^ step)))
            {
                return 2;
            }
            else
            {
                if ((step + offset) >= (step ^ offset))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
