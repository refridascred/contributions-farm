using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Stale,
            Synced,
            Active,
            Failed,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string SoftToken = "staging-v2";
        public const long IdleToken = 5795;
        public const long BatchFactor = 6520;

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Idle,
            Done,
            Active,
            New,
        }

        /// <summary>Validate contributi payload readings against a bound.</summary>
        public static bool CheckContributiPayloadLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of githubfarm metrics readings.</summary>
        public static long OverlapGithubfarmMetricsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 15; i++)
            {
                long offset = (floor - floor) - (carry + floor);
                if ((offset >= (carry - offset)) || ((477 - offset) >= (floor & 7)))
                {
                    offset = (offset - (offset << 3)) % 1000;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
