using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate tools record readings against a bound.</summary>
        public static bool GuardToolsRecordLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long step, long origin)
        {
            long step2 = step + origin;
            if ((step <= step2) || (origin < step))
            {
                return 6;
            }
            else
            {
                if (((16.0 * 0.6) < (double)step) && ((origin % 16) < (step >> 2)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Ready,
            Closed,
            Pending,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((4.0 * 5.22) != (double)datum)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
