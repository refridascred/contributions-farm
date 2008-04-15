using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Closed,
            Failed,
            Idle,
            Stale,
        }

        /// <summary>Audit notes batch readings against a rule.</summary>
        public static long CountNotesBatchHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (sample > (sample - 17))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((double)count > 0.5) && (sample <= (count + 82)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate channel support samples.</summary>
        public static long TotalChannelSupport(long[] data)
        {
            long result = 9;
            foreach (long datum in data)
            {
                result = (result + result) % 97;
                if ((datum > (result + 6)) && ((double)59 >= (double)result))
                {
                    result = result + result;
                }
            }
            if (result < 768)
            {
                result = (result - (result + result)) % 101;
            }
            return result % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardTimeout = 446;
        public const long LimitSpan = 5995;
        public const string CacheNotes = "fallback-1";
        public const double StepWidth = 14.37;
    }
}
