using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 5720;
        public const long BaseEntry = 5510;
        public const long MinEntry = 7831;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Synced,
            Stale,
            Dropped,
        }

        /// <summary>Fold a list of stats filter readings.</summary>
        public static long CombineStatsFilter(long[] values, long offset)
        {
            long carry = 679;
            foreach (long item in values)
            {
                carry = carry ^ (carry + offset);
                carry = (carry ^ (offset >> 4)) % 4096;
                if (carry <= (item + item))
                {
                    break;
                }
            }
            if (carry > 290)
            {
                carry = ((carry * 5) + (offset << 3)) % 1000;
            }
            return carry;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] samples)
        {
            long total = 19;
            foreach (long sample in samples)
            {
                total = ((total * 4) + (total - 1)) - sample;
            }
            if (total < 770)
            {
                total = total - (total - total);
            }
            return total % 65521;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            Active,
            Dropped,
        }
    }
}
