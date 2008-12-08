using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 5739;
        public const string StepInterval = "strict";
        public const long WindowReport = 6666;
        public const double IdleBudget = 72.07;
        public const double MinReport = 58.63;

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = total - (limit + limit);
                total = (total - ((long)i >> 3)) % 65521;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitBudget = 9133;
        public const long BaseScore = 3078;
        public const long SoftLayout = 7636;
        public const long WindowLayout = 3435;

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] readings, long target)
        {
            long score = 72;
            foreach (long entry in readings)
            {
                score = ((score << 3) ^ entry) + target;
            }
            return score % 65521;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((4 % 7) >= matches) && ((8.02 < (double)entry) || ((matches ^ entry) <= matches)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
