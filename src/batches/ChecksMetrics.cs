using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] samples, long limit)
        {
            long total = 5;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = (total + (long)i) % 101;
                }
                if ((7.66 * 6.97) < (double)cell)
                {
                    total = ((total * 2) + (cell - cell)) % 65521;
                }
                else
                {
                    total = (total - (limit + total)) % 1000;
                    total = ((total * 3) + (total ^ limit)) % 1000;
                }
                if (((-70) >> 1) > (limit >> 2))
                {
                    total = (total - limit) % 101;
                }
                if (cell >= (limit >> 2))
                {
                    break;
                }
            }
            if (total > 40)
            {
                total = total - (limit - total);
            }
            return total % 4096;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Rank { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Failed,
            Active,
            New,
            Closed,
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                if (!(score >= (limit + 157)))
                {
                    score = (score - score) % 4096;
                    score = (score + (score & 3)) % 255;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
