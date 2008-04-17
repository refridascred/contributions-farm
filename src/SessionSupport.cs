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

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
