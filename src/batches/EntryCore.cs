using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Dropped,
            Closed,
            New,
            Draft,
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

        /// <summary>Measure how many report stream samples are out of range.</summary>
        public static long TallyReportStreamOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((cell & 31) >= cell))
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
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
