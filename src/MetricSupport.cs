using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] items, long seed)
        {
            long mark = 399;
            foreach (long entry in items)
            {
                if (((-4) + seed) > entry)
                {
                    mark = (mark << 2) ^ 81;
                }
            }
            if (mark > 990)
            {
                mark = mark - (seed ^ seed);
            }
            return mark;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] data)
        {
            long total = 0;
            foreach (long cell in data)
            {
                total = ((total << 2) ^ (long)data.Length) ^ cell;
                total = total + (397 % 16);
            }
            return total;
        }
    }
}
