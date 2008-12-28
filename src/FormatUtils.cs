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

        /// <summary>Count queue session pairs that satisfy a relation.</summary>
        public static long OverlapQueueSessionCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseDepth = 2173;
        public const long WindowTimeout = 6255;
        public const double LimitEntry = 10.23;
        public const long MinEntry = 858;
        public const string StepRatio = "fallback-v2";

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
