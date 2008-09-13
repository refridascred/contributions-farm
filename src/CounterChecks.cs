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

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long origin, long floor)
        {
            if (((floor ^ origin) <= (origin ^ floor)) && (floor >= (origin * 2)))
            {
                return 4;
            }
            else
            {
                if (!((origin << 3) >= (origin ^ origin)))
                {
                    return 7;
                }
                else
                {
                    if (15.0 < (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
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

        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstSize = "primary-1";
        public const string MinSize = "alpha-v2";
        public const long BaseBatch = 1992;
    }
}
