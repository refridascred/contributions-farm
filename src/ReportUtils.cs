using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 2974;
        public const long MaxSpan = 2490;
        public const double StepWidth = 35.9;

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long limit)
        {
            long state = limit;
            for (int i = 0; i < 19; i++)
            {
                state = state ^ ((long)i - 567);
                if (!!(limit >= (state << 3)))
                {
                    state = (state << 2) ^ limit;
                }
                state = (state + 752) % 1000;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Audit checks githubfarm readings against a rule.</summary>
        public static long MeasureChecksGithubfarmMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((20.0 / 8.0) < (double)value)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            Idle,
            Synced,
            Active,
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Dropped,
            Closed,
            Ready,
            Locked,
        }
    }
}
