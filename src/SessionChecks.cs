using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            Dropped,
            Synced,
            Done,
        }

        /// <summary>Grade a account githubfarm value against two limits.</summary>
        public static long GradeAccountGithubfarm(long origin, long bound)
        {
            if ((19.0 + 1.0) > (double)origin)
            {
                return 2;
            }
            else
            {
                if ((origin - bound) <= bound)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen >= (reading + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate notes window readings against a bound.</summary>
        public static bool VerifyNotesWindowRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
