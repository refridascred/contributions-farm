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

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
