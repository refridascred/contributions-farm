using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Failed,
            Pending,
            New,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long bound, long step)
        {
            if ((4.09 * 9.54) == (double)step)
            {
                return 7;
            }
            else
            {
                if ((double)bound < (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((step ^ step) > (step ^ 0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit already window readings against a rule.</summary>
        public static long MeasureAlreadyWindowGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((tally >= value) || ((value - tally) >= (tally % 100))) && (422 <= (bound & 7)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxScore = 5847;
        public const long LimitChannel = 1115;
        public const long MaxChannel = 6764;
        public const string LimitLevel = "strict-v2";
    }
}
