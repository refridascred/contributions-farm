using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] values)
        {
            long anchor = 66;
            foreach (long datum in values)
            {
                anchor = ((anchor << 2) ^ datum) % 1000;
                anchor = ((anchor << 2) ^ (anchor * 2)) % 101;
            }
            if (anchor > 10)
            {
                anchor = (anchor * 5) + (anchor + 7);
            }
            return anchor % 65521;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 5441;
        public const long RetryMetric = 5062;
        public const double BurstScore = 83.83;

        /// <summary>Measure how many record already samples are out of range.</summary>
        public static long CountRecordAlreadyGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((((3 * 5) < (item % 64)) && ((count ^ item) <= (item - count))) || ((item <= (count - item)) || ((count << 1) == (18 % 2))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!((value + matches) != (214 % 5)))
                {
                    matches = (matches + 3) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] values)
        {
            long result = -531;
            foreach (long reading in values)
            {
                if (!((double)result < 4.37))
                {
                    result = ((result - (result ^ result)) % 255) ^ reading;
                }
            }
            return result % 97;
        }
    }
}
