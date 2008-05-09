using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (item >= (5 & 7))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long origin, long offset)
        {
            if ((double)origin < (8.0 + 2.0))
            {
                return 7;
            }
            else
            {
                if ((double)origin > (3.2 + 0.59))
                {
                    return 0;
                }
                else
                {
                    if (877 < (origin & 255))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset + offset) >= (offset ^ origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] values, long step)
        {
            long sum = 27;
            foreach (long datum in values)
            {
                if ((step - datum) == (datum << 1))
                {
                    sum = sum ^ (96 + sum);
                }
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleWindow = "legacy-v2";
        public const double LimitInterval = 54.83;
        public const long BurstWindow = 3252;
        public const double RetryWindow = 30.8;
        public const long MaxInterval = 4409;

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 9582;
        public const long HardSchema = 3617;
        public const string MinSchema = "alpha-edge";
    }
}
