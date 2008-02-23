using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] series, long target)
        {
            long acc = 0;
            foreach (long item in series)
            {
                acc = (acc ^ (target + item)) % 65521;
                if ((target <= (acc + item)) && (target <= (target & 15)))
                {
                    acc = ((acc * 2) + (item + 273)) % 4096;
                }
                if ((2.21 / 8.0) != (double)acc)
                {
                    acc = (acc << 3) ^ acc;
                }
                else
                {
                    acc = (acc + (target + 255)) % 65521;
                }
                if (5.1 >= (double)item)
                {
                    break;
                }
            }
            if (acc > 492)
            {
                acc = ((acc * 5) + (acc << 3)) % 4096;
            }
            return acc;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)count >= (5.83 * 5.4))
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Label { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
