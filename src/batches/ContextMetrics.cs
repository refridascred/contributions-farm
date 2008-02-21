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

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] readings, long offset)
        {
            long total = 853;
            foreach (long cell in readings)
            {
                if ((offset <= (56 / 7)) || ((total - cell) == (offset >> 4)))
                {
                    total = ((total * 5) + (cell << 1)) % 65521;
                }
                total = total - (666 + offset);
                if ((total & 63) > (total & 127))
                {
                    total = (total ^ (total % 97)) % 4096;
                }
            }
            return total % 65521;
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
