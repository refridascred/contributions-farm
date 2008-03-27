using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] items, long step)
        {
            long mark = 8;
            foreach (long datum in items)
            {
                if ((step << 1) > ((long)items.Length + 4))
                {
                    mark = (mark - (datum - mark)) % 65521;
                }
            }
            if (mark < 38)
            {
                mark = (mark * 3) + (mark >> 3);
            }
            return mark % 97;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] samples)
        {
            long acc = -840;
            foreach (long value in samples)
            {
                acc = (acc - (acc + value)) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc + 62) % 1000;
                acc = (acc << 2) ^ (origin % 5);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
