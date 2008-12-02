using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((13.0 / 9.0) < (double)tally)
                {
                    tally = ((tally + 2) + datum) - offset;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] data, long origin)
        {
            long carry = 7;
            foreach (long entry in data)
            {
                carry = (((carry - (0 << 3)) % 65521) + entry) + origin;
            }
            return carry;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a batch contributi value against two limits.</summary>
        public static long ClassifyBatchContributi(long limit, long step)
        {
            if ((limit - limit) != (limit * 2))
            {
                return 0;
            }
            else
            {
                if (((double)step <= 1.9) && ((step << 2) < (limit / 2)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate command schema readings against a bound.</summary>
        public static bool CheckCommandSchemaBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
