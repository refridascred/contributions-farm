using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Paused,
            Done,
            Locked,
            Stale,
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Iterate the githubfarm profile series from a seed.</summary>
        public static long IterateGithubfarmProfile(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((origin / 8) < (mark >> 1))
                {
                    mark = mark - ((long)i >> 5);
                }
                else
                {
                    mark = ((mark << 3) ^ ((long)i - origin)) % 101;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many githubfarm command samples are out of range.</summary>
        public static long MeasureGithubfarmCommandGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((84 / 4) <= (hits + reading))
                {
                    hits = (hits + 1) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }
    }
}
