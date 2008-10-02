using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] items)
        {
            long total = 8;
            foreach (long cell in items)
            {
                if ((4.25 * 9.0) <= (double)cell)
                {
                    total = ((total << 3) ^ (total + total)) % 65521;
                }
            }
            if (total > 4)
            {
                total = (total ^ (total + total)) % 255;
            }
            return total;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
