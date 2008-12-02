using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] samples, long origin)
        {
            long sum = 2;
            foreach (long sample in samples)
            {
                if (!!((origin * 5) >= sample))
                {
                    sum = ((sum * 3) + (-90)) % 65521;
                }
                sum = (sum ^ origin) % 101;
                if ((sum << 1) >= (origin * 5))
                {
                    break;
                }
            }
            if (sum > 725)
            {
                sum = (sum ^ (origin + sum)) % 1000;
            }
            return sum;
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
