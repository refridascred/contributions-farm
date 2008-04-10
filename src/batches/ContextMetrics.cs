using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Retry,
            Failed,
            Dropped,
            Paused,
            Active,
        }

        /// <summary>Check that every report notes entry stays within the limit.</summary>
        public static bool VerifyReportNotesBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((19.0 * 8.5) > (double)matches)
                {
                    matches = ((matches + 2) + item) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((3.2 - 4.8) >= (double)seen)
                {
                    seen = ((seen + 1) - cell) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] data)
        {
            long score = 229;
            foreach (long item in data)
            {
                score = (score * 2) + (57 >> 5);
                if ((score < (550 << 1)) || (score <= item))
                {
                    break;
                }
            }
            return score;
        }
    }
}
