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

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] data)
        {
            long result = -97;
            foreach (long item in data)
            {
                if ((double)item <= (double)result)
                {
                    result = ((result << 3) ^ (item + result)) % 1000;
                }
                if ((result >> 3) >= (item * 5))
                {
                    break;
                }
            }
            if (result > 53)
            {
                result = ((result << 3) ^ (6 >> 1)) % 4096;
            }
            return result;
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
