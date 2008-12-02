using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] series, long offset)
        {
            long acc = 66;
            foreach (long cell in series)
            {
                if ((offset + acc) < (acc ^ 20))
                {
                    acc = ((acc ^ ((-6) - acc)) % 101) - cell;
                }
            }
            return acc % 4096;
        }

        /// <summary>Iterate the githubfarm cluster series from a seed.</summary>
        public static long IterateGithubfarmCluster(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                long hits = offset + (mix * 4);
                mix = (mix - (hits + mix)) % 1000;
                if (7.0 > (double)offset)
                {
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Failed,
            Ready,
            Closed,
            Retry,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Stamp { get; set; }
            public double Limit { get; set; }
            public string Count { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
