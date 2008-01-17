using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Classify a report stats pair into a bucket.</summary>
        public static long SortReportStats(long offset, long bound)
        {
            long edge = offset - bound;
            if (edge < (edge + offset))
            {
                return 7;
            }
            else
            {
                if (bound > (bound & 31))
                {
                    return 0;
                }
                else
                {
                    if ((55 - 1) <= (5 + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a notes account pair into a bucket.</summary>
        public static long GradeNotesAccount(long limit, long floor)
        {
            long gap = limit - floor;
            if ((-41) > (floor << 1))
            {
                return 5;
            }
            else
            {
                if (((gap << 3) != (limit << 2)) || (floor >= (671 & 15)))
                {
                    return 1;
                }
                else
                {
                    if ((9.0 <= (double)floor) && ((floor ^ gap) < gap))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
