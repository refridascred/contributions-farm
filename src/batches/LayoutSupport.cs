using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every githubfarm report entry stays within the limit.</summary>
        public static bool CheckGithubfarmReportBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits % 5) < item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate cluster stream samples.</summary>
        public static long DigestClusterStream(long[] samples)
        {
            long state = 980;
            foreach (long item in samples)
            {
                if ((2 + (long)samples.Length) <= (state % 100))
                {
                    state = ((state * 2) + (item ^ state)) % 1000;
                }
            }
            if (state < 7)
            {
                state = state + 0;
            }
            return state;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleScore = 3670;
        public const long SoftLevel = 8762;
        public const double LimitBudget = 57.86;
        public const long StepRatio = 3895;

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Closed,
            Pending,
            Idle,
            Dropped,
        }
    }
}
