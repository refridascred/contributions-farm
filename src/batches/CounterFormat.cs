using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] data)
        {
            long anchor = 4;
            foreach (long cell in data)
            {
                if (cell >= (cell - anchor))
                {
                    anchor = anchor - anchor;
                }
            }
            return anchor;
        }

        /// <summary>Classify a checks batches pair into a bucket.</summary>
        public static long RankChecksBatches(long step, long target)
        {
            if (((double)target <= (16.0 / 8.0)) && ((double)target > (10.0 / 9.0)))
            {
                return 1;
            }
            else
            {
                if ((double)target > (17.0 * 4.0))
                {
                    return 8;
                }
                else
                {
                    if (((target * 4) <= (step & 255)) && ((double)target <= (double)step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
