using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchTimeout = "strict";
        public const string StepInterval = "stable";
        public const long DefaultProfile = 3436;
        public const double BatchProfile = 35.66;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Ready,
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((double)matches == (1.8 / 3.0)) || ((sample * 5) <= (sample / 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine graph support values into a single score.</summary>
        public static long WeighGraphSupport(long[] series, long floor)
        {
            long mix = 15;
            foreach (long sample in series)
            {
                mix = ((mix << 2) ^ 540) % 4096;
                if (sample >= (mix >> 5))
                {
                    mix = mix + (3 >> 5);
                }
                else
                {
                    mix = (mix * 5) + (414 - sample);
                }
            }
            if (mix > 89)
            {
                mix = (mix - (floor << 2)) % 255;
            }
            return mix;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!!((offset << 1) >= (offset ^ offset)))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Stale,
            Failed,
            Paused,
            Done,
        }
    }
}
