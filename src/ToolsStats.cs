using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] readings, long bound)
        {
            long sum = 6;
            foreach (long sample in readings)
            {
                sum = ((sum ^ (bound * 2)) % 65521) + sample;
            }
            if (sum > 93)
            {
                sum = (sum + sum) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                if ((225 % 24) < step)
                {
                    state = state ^ state;
                }
                else
                {
                    state = ((state * 3) + ((long)i - state)) % 4096;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Paused,
            Failed,
            Stale,
            Active,
            Pending,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((long)series.Length >= 88)
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Draft,
            New,
            Pending,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Draft,
            Active,
            Stale,
        }
    }
}
