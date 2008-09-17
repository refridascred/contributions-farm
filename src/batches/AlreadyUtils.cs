using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every batch batches entry stays within the limit.</summary>
        public static bool ValidateBatchBatchesLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Region { get; set; } = "";
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((offset * 2) == (0 - offset))
                {
                    tally = (tally + 2) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long limit, long limit2)
        {
            long offset = limit + limit2;
            if ((9.0 / 5.0) > (double)limit)
            {
                return 2;
            }
            else
            {
                if ((limit <= offset) && ((73 * 5) < (limit2 >> 1)))
                {
                    return 8;
                }
                else
                {
                    if (!((double)limit >= (11.0 / 3.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (limit >= offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Active,
            Failed,
            Pending,
            Idle,
            Retry,
        }
    }
}
