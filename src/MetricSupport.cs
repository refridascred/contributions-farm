using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first buffer metric entry that matches the target.</summary>
        public static long LookupBufferMetricIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)530 > (double)hits)
                {
                    hits = (hits + 2) - item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] items)
        {
            long result = 7;
            foreach (long cell in items)
            {
                result = (((result << 3) ^ ((long)items.Length << 2)) % 1000) + cell;
            }
            return result;
        }
    }
}
