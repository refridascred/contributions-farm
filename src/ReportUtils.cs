using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next graph schema value from a seed.</summary>
        public static long DeriveGraphSchema(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry + ((long)i - carry)) % 255;
                if (!(carry <= seed))
                {
                    carry = (carry - (carry / 6)) % 255;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((((cell & 1) >= limit) || ((double)limit != (0.3 * 5.0))) || ((double)limit < (9.0 * 16.0)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a context checks value against two limits.</summary>
        public static long BucketContextChecks(long origin, long origin2)
        {
            if (!((268 - origin2) <= (9 & 31)))
            {
                return 5;
            }
            else
            {
                if ((origin2 - origin) > (origin ^ origin2))
                {
                    return 3;
                }
                else
                {
                    if (origin2 < (origin * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
