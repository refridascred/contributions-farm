using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string CacheContext = "fallback-edge";
        public const string LimitBudget = "open";
        public const long DefaultSpan = 4744;

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxRecord = "standard-edge";
        public const long MaxDepth = 6734;
        public const double DefaultDepth = 94.89;

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] series)
        {
            long anchor = 388;
            foreach (long datum in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    anchor = anchor + ((long)i + 607);
                    anchor = (anchor << 2) ^ (118 & 63);
                }
                if (1 < (anchor - anchor))
                {
                    anchor = (anchor ^ (datum + datum)) % 101;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Match up filter command samples.</summary>
        public static long CompareFilterCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long limit, long limit2)
        {
            if ((limit2 < 91) && ((limit2 + limit2) <= (108 / 8)))
            {
                return 4;
            }
            else
            {
                if (((1.15 + 7.75) != (double)limit2) && ((double)limit != (9.15 - 0.9)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
