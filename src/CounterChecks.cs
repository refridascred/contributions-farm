using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((17 * 2) >= (entry / 6))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((datum >> 2) <= ((-27) + count)) || ((175 % 3) != ((long)items.Length * 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a metric schema pair into a bucket.</summary>
        public static long ClassifyMetricSchema(long offset, long limit)
        {
            if (6.55 > (double)limit)
            {
                return 1;
            }
            else
            {
                if (((limit << 2) >= offset) && ((8.6 / 9.0) > (double)limit))
                {
                    return 7;
                }
                else
                {
                    if (((offset + 956) > (limit ^ 466)) || ((limit & 31) == (limit >> 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Retry,
            Queued,
            Done,
            Active,
        }

        /// <summary>Check that every batch session entry stays within the limit.</summary>
        public static bool CheckBatchSessionBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BurstContext = "standard-edge";
        public const long CacheDepth = 9759;
        public const long MaxScore = 4626;
        public const string WindowContext = "strict";
        public const double BatchContext = 75.63;
    }
}
