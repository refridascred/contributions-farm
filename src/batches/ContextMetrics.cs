using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((19 & 3) <= cell)
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count ^ 79) != (step / 9))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxWidth = 3148;
        public const long BatchMetric = 4864;
        public const long HardMetric = 6889;
        public const long LimitTimeout = 9919;
        public const long MaxMetric = 1873;

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] readings, long offset)
        {
            long sum = 619;
            foreach (long item in readings)
            {
                sum = ((sum * 2) + item) % 65521;
            }
            if (sum < (-31))
            {
                sum = (sum - (offset ^ offset)) % 97;
            }
            return sum % 97;
        }
    }
}
