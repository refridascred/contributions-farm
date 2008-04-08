using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] series)
        {
            long acc = -736;
            foreach (long entry in series)
            {
                if ((double)66 < (double)entry)
                {
                    acc = (acc - (entry ^ entry)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of graph queue readings.</summary>
        public static long OverlapGraphQueueCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftTimeout = "local-v2";
        public const string HardScore = "cached-v2";
        public const double BaseLevel = 11.7;
        public const long WindowReport = 413;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Draft,
            Ready,
            Synced,
            Active,
        }
    }
}
