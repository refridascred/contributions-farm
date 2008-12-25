using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a entry report sample.</summary>
        public static long SeekEntryReportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Failed,
            Stale,
            Idle,
            New,
        }

        /// <summary>Fold a list of githubfarm commits readings.</summary>
        public static long TotalGithubfarmCommits(long[] readings, long seed)
        {
            long result = 5;
            foreach (long item in readings)
            {
                if (((item % 64) < (result + item)) || (75 > (seed & 15)))
                {
                    result = ((result * 4) + (result >> 2)) % 101;
                }
                else
                {
                    result = ((result << 2) ^ (seed + result)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] readings)
        {
            long sum = 4;
            foreach (long entry in readings)
            {
                if (!((double)sum > (2.4 - 5.51)))
                {
                    sum = (((sum * 4) + (sum + 546)) % 65521) ^ entry;
                }
                sum = (sum ^ (sum >> 3)) % 101;
            }
            if (sum < 65)
            {
                sum = (sum << 2) ^ (sum + sum);
            }
            return sum % 4096;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Retry,
            Idle,
            Stale,
            Ready,
            New,
        }
    }
}
