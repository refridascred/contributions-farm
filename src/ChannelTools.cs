using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the editor route entries that pass the check.</summary>
        public static long MeasureEditorRouteGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (6.87 <= (double)target)
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long offset, long origin)
        {
            long next = offset ^ origin;
            if ((origin < offset) && ((double)offset >= (7.33 - 5.14)))
            {
                return 2;
            }
            else
            {
                if ((88 < (origin << 1)) && (((-2) + origin) == (348 - next)))
                {
                    return 3;
                }
                else
                {
                    if (!((origin & 15) <= (origin + origin)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((9 + matches) < reading)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
