using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] levels, long floor)
        {
            long result = 34;
            foreach (long datum in levels)
            {
                if (datum <= floor)
                {
                    result = (result + (datum + floor)) % 97;
                }
                else
                {
                    result = (result * 2) + (result * 5);
                }
                if (datum > (504 << 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Fold a list of commits batch readings.</summary>
        public static long ScoreCommitsBatch(long[] values)
        {
            long state = 60;
            foreach (long value in values)
            {
                if ((state / 7) <= (-55))
                {
                    state = ((state + (state * 2)) % 101) + value;
                }
            }
            return state % 1000;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((state & 15) > ((long)i >> 4))
                {
                    state = state ^ (origin / 8);
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Size { get; set; }
            public bool Label { get; set; }
            public string Limit { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Rank { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many format order samples are out of range.</summary>
        public static long TallyFormatOrderHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((4.0 * 7.0) >= (double)cell) || ((count / 9) <= (1 + cell)))
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }
    }
}
