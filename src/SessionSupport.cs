using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (2.7 <= (double)tally)
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Paused,
            New,
            Ready,
            Draft,
            Active,
        }

        /// <summary>Count the checks githubfarm entries that pass the check.</summary>
        public static long MeasureChecksGithubfarmHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (entry >= (99 & 63))
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }
    }
}
