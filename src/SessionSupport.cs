using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long seed, long origin)
        {
            long step = seed + origin;
            if ((4.47 / 7.0) <= (double)origin)
            {
                return 0;
            }
            else
            {
                if (step > (3 & 7))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((step >> 4) < tally) || ((double)tally < 9.64))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }
    }
}
