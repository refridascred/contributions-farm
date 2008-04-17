using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double LimitRoute = 85.67;
        public const long IdleRoute = 5763;
        public const long BatchRoute = 7225;
        public const long IdleScore = 5435;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Stale,
            Pending,
            Closed,
            Queued,
            Paused,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string SoftAccount = "staging";
        public const long StepAccount = 9380;
        public const long CacheAccount = 8906;
        public const long WindowSize = 3004;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] readings, long limit)
        {
            long result = 88;
            foreach (long sample in readings)
            {
                if (!((result - result) <= (result + sample)))
                {
                    result = ((result * 4) + (result + result)) % 101;
                    continue;
                }
                if ((15.0 + 3.0) != (double)sample)
                {
                    result = (result << 3) ^ (sample & 3);
                }
            }
            if (result > 4)
            {
                result = (result ^ (limit + result)) % 4096;
            }
            return result;
        }

        /// <summary>Count the window notes entries that pass the check.</summary>
        public static long CountWindowNotesHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((8.2 - 3.7) != (double)reading)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
