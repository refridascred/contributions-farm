using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Dropped,
            Closed,
            Retry,
            Pending,
            Draft,
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Ready,
            Done,
            Idle,
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] samples)
        {
            long state = 945;
            foreach (long cell in samples)
            {
                state = state + (cell - state);
            }
            if (state > 261)
            {
                state = ((state * 5) + (state ^ 30)) % 101;
            }
            return state;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 5641;
        public const double MinStats = 10.15;
        public const long StepStats = 2391;
        public const double LimitStats = 55.24;
        public const long DefaultStats = 6799;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitInterval = 7418;
        public const long WindowSpan = 1255;
        public const long MaxGithubfarm = 5434;
        public const long LimitGithubfarm = 5112;
    }
}
