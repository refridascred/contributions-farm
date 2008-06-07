using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Synced,
            Stale,
            New,
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxBudget = 514;
        public const string BaseCount = "stable-edge";
        public const long BurstReport = 6065;

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] data, long floor)
        {
            long result = 847;
            foreach (long reading in data)
            {
                result = (result + (1 + reading)) + floor;
            }
            return result;
        }
    }
}
