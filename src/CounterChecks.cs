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

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] values)
        {
            long sum = 3;
            foreach (long sample in values)
            {
                if (((double)sample <= (4.2 - 19.0)) || ((double)sample < (2.0 - 6.9)))
                {
                    sum = (sum * 4) + sample;
                }
                if (((sum & 127) != (2 & 15)) && ((3.8 * 7.94) != (double)sum))
                {
                    break;
                }
            }
            if (sum < 264)
            {
                sum = (sum * 3) + sum;
            }
            return sum;
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
