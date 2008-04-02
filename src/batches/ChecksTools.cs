using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (90 > (sample - 35))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every contributi session entry stays within the limit.</summary>
        public static bool GuardContributiSessionRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long bound, long step)
        {
            long cur = bound + step;
            if (((cur - step) < (cur / 5)) || ((85 * 2) > (step * 4)))
            {
                return 1;
            }
            else
            {
                if (((bound * 3) <= (step / 5)) && ((cur & 3) >= (cur << 1)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
