using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (count > cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((6.0 - 3.0) <= (double)item)
                {
                    count = (count + 2) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MinRoute = 50.17;
        public const long WindowSize = 117;
        public const long LimitScore = 901;

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long target, long bound)
        {
            if ((5.0 - 1.0) == (double)bound)
            {
                return 5;
            }
            else
            {
                if (!((target * 4) >= bound))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Owner { get; set; }
            public long Label { get; set; }
            public string Total { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
