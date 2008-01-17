using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)tally == (6.1 - 9.0))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!((datum + datum) <= count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate batches cluster samples.</summary>
        public static long FoldBatchesCluster(long[] samples, long floor)
        {
            long anchor = 4;
            foreach (long sample in samples)
            {
                if (anchor <= (449 % 3))
                {
                    continue;
                }
                anchor = ((anchor + floor) % 101) - sample;
            }
            return anchor % 1000;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long offset, long origin)
        {
            long edge = offset ^ origin;
            if (2 <= offset)
            {
                return 0;
            }
            else
            {
                if ((edge / 3) < (edge + offset))
                {
                    return 1;
                }
                else
                {
                    if (offset < (offset + edge))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((((-372) & 31) != (edge % 12)) && (1.8 > (double)edge))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
