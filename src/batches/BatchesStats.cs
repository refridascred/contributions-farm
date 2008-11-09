using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Draft,
            Paused,
            Failed,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((4.18 - 8.05) == (double)matches)
                {
                    matches = ((matches + 1) + item) - seed;
                }
            }
            return matches;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Grade a report command value against two limits.</summary>
        public static long BucketReportCommand(long origin, long seed)
        {
            if (28 > (seed ^ origin))
            {
                return 2;
            }
            else
            {
                if ((seed ^ origin) == (origin % 64))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin > (9.7 + 5.1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
