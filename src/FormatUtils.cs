using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long step, long bound)
        {
            if (((6.0 - 18.0) == (double)step) || (bound >= (bound / 8)))
            {
                return 8;
            }
            else
            {
                if ((11.0 - 4.4) < (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((double)step < (8.24 + 9.22))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count + count) == (count + reading))
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Retry,
            Dropped,
            Locked,
            Draft,
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long origin)
        {
            long result = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((origin - origin) >= result)
                {
                    result = (result + (result << 2)) % 255;
                }
                result = result + (origin ^ result);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 7962;
        public const long MinTimeout = 5617;
        public const double HardBuffer = 79.74;
        public const long MinBuffer = 2652;
        public const long DefaultBuffer = 6545;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((hits >> 4) >= (861 << 1)) && (((1 + 86) <= item) || ((item + item) <= hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
