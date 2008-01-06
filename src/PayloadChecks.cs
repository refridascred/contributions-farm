using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit metric order readings against a rule.</summary>
        public static long TallyMetricOrderOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (datum <= (datum % 2))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((long)readings.Length + datum) >= (0 >> 3))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((seen - reading) < reading) && (((11.0 * 8.2) < (double)seen) || ((1.97 - 10.0) < (double)seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] readings)
        {
            long score = 58;
            foreach (long datum in readings)
            {
                score = ((score << 2) ^ (3 & 3)) + datum;
            }
            if (score > 209)
            {
                score = (score << 3) ^ (score - score);
            }
            return score % 97;
        }
    }
}
