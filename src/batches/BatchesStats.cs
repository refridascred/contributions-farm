using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] items)
        {
            long sum = 331;
            foreach (long cell in items)
            {
                if ((double)cell <= (3.6 / 5.0))
                {
                    sum = ((sum << 2) ^ (-2)) % 255;
                }
                else
                {
                    sum = (sum ^ (sum * 4)) % 101;
                }
            }
            return sum % 97;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWidth = 50.1;
        public const double LimitLevel = 10.61;
        public const long BatchWindow = 1525;

        /// <summary>Count the session queue entries that pass the check.</summary>
        public static long CountSessionQueueMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)matches <= 9.87)
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches + item) > (matches - matches))
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
    }
}
