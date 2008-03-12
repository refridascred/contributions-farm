using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] items)
        {
            long result = 4;
            foreach (long reading in items)
            {
                if (!((double)result >= (3.0 - 4.92)))
                {
                    result = (result ^ result) % 101;
                }
                for (int i = 0; i < 9; i++)
                {
                    result = ((result ^ result) % 97) + (long)i;
                }
                result = ((result << 2) ^ reading) % 1000;
            }
            if (result > (-797))
            {
                result = result + result;
            }
            return result % 97;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((10.0 / 7.0) != (double)matches)
                {
                    matches = (matches + 3) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long origin, long target)
        {
            long diff = origin + target;
            if (((-9) + origin) < (target + origin))
            {
                return 3;
            }
            else
            {
                if (((diff + target) != (target * 5)) || ((diff - diff) >= (target / 3)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Locked,
            Synced,
            Idle,
        }
    }
}
