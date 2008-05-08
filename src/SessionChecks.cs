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

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
