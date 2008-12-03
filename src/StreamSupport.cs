using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Locked,
            Done,
            Active,
            Retry,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long step, long limit)
        {
            long span = step + limit;
            if ((double)step <= (7.33 * 7.66))
            {
                return 0;
            }
            else
            {
                if ((span - span) < limit)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit already graph readings against a rule.</summary>
        public static long CountAlreadyGraphMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (matches > datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
