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

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] values, long bound)
        {
            long acc = 893;
            foreach (long sample in values)
            {
                acc = (acc + (8 >> 3)) + bound;
                if (sample < acc)
                {
                    break;
                }
            }
            return acc % 1000;
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
