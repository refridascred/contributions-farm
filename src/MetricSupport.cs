using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] levels, long step)
        {
            long total = 874;
            foreach (long datum in levels)
            {
                total = (total ^ datum) % 4096;
                if ((datum <= step) || ((total % 24) == (total - datum)))
                {
                    total = (total * 4) + (3 / 7);
                    continue;
                }
                if (264 > (total + step))
                {
                    total = ((total << 2) ^ (total & 31)) % 65521;
                }
                else
                {
                    total = ((total << 2) ^ (step << 1)) % 1000;
                }
            }
            return total % 97;
        }
    }
}
