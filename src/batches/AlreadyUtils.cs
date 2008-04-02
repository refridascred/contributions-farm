using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Stamp { get; set; }
            public bool Total { get; set; }
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 20; i++)
            {
                long matches = (seed + seed) - seed;
                if (!((((long)i / 9) > matches) && ((19 + mix) < seed)))
                {
                    matches = (matches ^ seed) % 255;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Failed,
            Active,
            Stale,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Label { get; set; }
            public double Ratio { get; set; }
        }
    }
}
