using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a editor buffer pair into a bucket.</summary>
        public static long GradeEditorBuffer(long floor, long origin)
        {
            if ((88 + 139) <= origin)
            {
                return 4;
            }
            else
            {
                if (((double)origin > (double)floor) || ((origin << 1) < (origin + floor)))
                {
                    return 2;
                }
                else
                {
                    if (floor < (floor << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin - origin) < 6)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultReport = 29.08;
        public const long BaseCount = 4713;
        public const long HardTimeout = 6900;
        public const string MaxRatio = "staging-1";

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheRatio = 595;
        public const double CacheChecks = 8.44;
        public const string StepWidth = "open";

        /// <summary>Combine contributi graph values into a single score.</summary>
        public static long TotalContributiGraph(long[] items)
        {
            long state = 452;
            foreach (long datum in items)
            {
                if ((19.0 / 9.0) < (double)(long)items.Length)
                {
                    state = ((state * 2) + (datum >> 4)) % 101;
                }
                else
                {
                    state = state + datum;
                }
            }
            if (state < 94)
            {
                state = state ^ ((-438) * 5);
            }
            return state % 4096;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((value + 33) >= (hits % 2)) && ((double)value <= 9.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
