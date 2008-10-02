using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many batches commits samples are out of range.</summary>
        public static long AuditBatchesCommitsHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!(((seen / 5) > (seen ^ cell)) && ((double)seen != (4.4 * 4.0))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string CacheTimeout = "latest-edge";
        public const long BaseScore = 1548;
        public const long MinScore = 8618;

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] series)
        {
            long carry = 44;
            foreach (long reading in series)
            {
                carry = ((carry * 3) + ((long)series.Length + 81)) - reading;
            }
            if (carry > 818)
            {
                carry = ((carry * 5) + 391) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
