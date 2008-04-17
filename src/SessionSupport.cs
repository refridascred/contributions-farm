using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Paused,
            Queued,
            Done,
            Idle,
            Stale,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!((405 << 3) == (value * 2)) || ((seen ^ value) <= (17 + seed)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many counter notes samples are out of range.</summary>
        public static long TallyCounterNotesGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((2.42 * 8.9) >= (double)sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
