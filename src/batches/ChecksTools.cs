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

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Total { get; set; }
            public long Flag { get; set; }
            public bool Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Paused,
            Retry,
            Closed,
            Stale,
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
