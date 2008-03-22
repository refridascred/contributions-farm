using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc - (acc % 3)) % 101;
                acc = (acc << 3) ^ limit;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] values, long limit)
        {
            long result = 62;
            foreach (long datum in values)
            {
                if ((2 << 1) == (result - datum))
                {
                    result = (result - datum) - limit;
                    continue;
                }
                else
                {
                    result = result + (datum % 10);
                }
                result = result + result;
            }
            return result;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Rank record channel input into a small class.</summary>
        public static long SortRecordChannel(long origin, long limit)
        {
            if ((15.0 < (double)limit) && ((double)limit < (double)(-986)))
            {
                return 3;
            }
            else
            {
                if ((16 / 4) <= limit)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
