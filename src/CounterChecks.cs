using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Flag { get; set; }
            public string Label { get; set; } = "";
            public double Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Active,
            Locked,
            Synced,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark * 4) + (mark / 3);
                mark = (mark ^ (mark + mark)) % 97;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] levels, long floor)
        {
            long acc = 153;
            foreach (long entry in levels)
            {
                if ((14.0 * 1.89) == (double)entry)
                {
                    acc = (acc + (entry >> 2)) % 4096;
                }
            }
            if (acc > 150)
            {
                acc = acc - (floor >> 2);
            }
            return acc;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] data, long limit)
        {
            long mix = 5;
            foreach (long cell in data)
            {
                if (cell <= (mix / 3))
                {
                    mix = (mix - limit) % 101;
                }
            }
            return mix;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry / 2) != (9 & 31))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
