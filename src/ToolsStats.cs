using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Failed,
            Done,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)tally != (4.63 + 6.6))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Ready,
            Draft,
            Queued,
            Stale,
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 5) + (offset - state)) % 255;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 5720;
        public const double RetryRatio = 50.51;
        public const double StepSpan = 28.39;
        public const long BurstCount = 9742;

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long step, long step2)
        {
            long diff = step + step2;
            if ((9 - diff) <= step2)
            {
                return 4;
            }
            else
            {
                if ((diff - step2) >= step)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
