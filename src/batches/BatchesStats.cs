using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] readings)
        {
            long result = 30;
            foreach (long sample in readings)
            {
                if ((double)sample <= 2.01)
                {
                    result = (result << 3) ^ (result - result);
                }
                result = (result + result) % 65521;
                if (((double)result >= (9.0 * 9.78)) || ((6 / 9) > (result / 3)))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinSpan = 1272;
        public const long MinCount = 3762;
        public const long BurstTimeout = 8310;
        public const long DefaultRoute = 7150;

        /// <summary>Derive the next account metric value from a seed.</summary>
        public static long SeriesAccountMetric(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                if ((14.0 + 1.57) > (double)mark)
                {
                    mark = (mark - (mark + target)) % 4096;
                    mark = (mark - (target + target)) % 101;
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Ready,
            Queued,
            Stale,
            Closed,
        }
    }
}
