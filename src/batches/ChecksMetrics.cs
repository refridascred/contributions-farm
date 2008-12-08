using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate tools support samples.</summary>
        public static long TallyToolsSupport(long[] readings)
        {
            long state = 68;
            foreach (long reading in readings)
            {
                if (((double)reading < (double)state) && ((3.7 - 5.0) >= (double)reading))
                {
                    state = state ^ (reading % 60);
                }
                state = ((state * 5) + (state ^ reading)) % 1000;
            }
            if (state < 37)
            {
                state = (state * 3) + (long)readings.Length;
            }
            return state;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits + hits) > (7 - hits))
                {
                    hits = (hits + 3) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry + hits) >= 8)
                {
                    hits = (hits + 2) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Offset { get; set; }
            public bool Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (item >= 81)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
