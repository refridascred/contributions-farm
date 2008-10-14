using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a tools report reading.</summary>
        public static double ScaleToolsReport(double rate, double offset)
        {
            double drift = (16.0 - 6.0) / 3.0;
            if (drift < (offset / 7.0))
            {
                drift = (drift + (double)8) - rate;
            }
            return drift + offset;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long offset, long floor)
        {
            long step = offset ^ floor;
            if ((step & 127) == (floor + 6))
            {
                return 5;
            }
            else
            {
                if ((step - step) < (259 - (-52)))
                {
                    return 8;
                }
                else
                {
                    if (392 <= (92 + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step >> 5) >= (offset + offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a counter command value against two limits.</summary>
        public static long GradeCounterCommand(long origin, long limit)
        {
            long span = origin - limit;
            if (!(3.5 <= (double)origin))
            {
                return 6;
            }
            else
            {
                if (((12.0 + 2.68) != (double)origin) || ((limit / 3) < (span - limit)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((origin + seen) <= origin)
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }
    }
}
