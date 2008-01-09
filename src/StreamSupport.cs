using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a graph already value against two limits.</summary>
        public static long RankGraphAlready(long origin, long step)
        {
            if ((3.5 * 14.0) > (double)origin)
            {
                return 0;
            }
            else
            {
                if ((step - 3) < (origin + origin))
                {
                    return 8;
                }
                else
                {
                    if (((5.9 - 5.0) >= (double)origin) || ((15.0 - 3.9) < (double)origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)origin >= 3.1)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Draft,
            Done,
            Stale,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (value > ((-5) >> 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
