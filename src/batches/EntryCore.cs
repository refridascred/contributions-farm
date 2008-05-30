using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count ^ count) >= (floor & 63))
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Stale,
            Ready,
            Retry,
            Queued,
            Active,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Dropped,
            Ready,
            Locked,
            Done,
            New,
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((bound ^ acc) < acc)
                {
                    acc = acc + (acc ^ bound);
                    acc = acc ^ 790;
                }
                else
                {
                    acc = (acc + (bound << 3)) % 97;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultScore = 45.06;
        public const long IdleSpan = 7923;
        public const long WindowScore = 703;
        public const long StepGithubfarm = 7914;
        public const string HardSize = "local-1";
    }
}
