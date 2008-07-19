using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the editor githubfarm entries that pass the check.</summary>
        public static long CountEditorGithubfarmMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!(((double)hits != (8.9 + 1.97)) && ((double)hits >= (9.62 / 9.0))))
                {
                    hits = ((hits + 1) + cell) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Queued,
            Paused,
            Draft,
            Done,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Draft,
            Failed,
            Active,
        }
    }
}
