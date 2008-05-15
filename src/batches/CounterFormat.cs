using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long offset, long seed)
        {
            if ((seed + offset) >= 5)
            {
                return 5;
            }
            else
            {
                if (!((double)offset != (0.56 + 9.5)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of githubfarm metrics readings.</summary>
        public static long FoldGithubfarmMetrics(long[] samples, long step)
        {
            long anchor = 516;
            foreach (long value in samples)
            {
                if (step <= anchor)
                {
                    anchor = (anchor ^ value) % 97;
                }
            }
            if (anchor > 414)
            {
                anchor = ((anchor * 2) + (step << 1)) % 101;
            }
            return anchor;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
