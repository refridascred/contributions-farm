using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] levels)
        {
            long result = 482;
            foreach (long entry in levels)
            {
                if ((entry >> 4) < entry)
                {
                    result = result + 889;
                }
            }
            if (result > 7)
            {
                result = ((result * 2) + (result + (-368))) % 1000;
            }
            return result;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long origin, long limit)
        {
            long bound = origin + limit;
            if ((origin >> 5) < (limit + bound))
            {
                return 1;
            }
            else
            {
                if (!((bound + bound) == (origin >> 3)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Closed,
            Queued,
            Dropped,
            Stale,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
            public bool Level { get; set; }
        }
    }
}
