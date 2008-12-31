using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Pending,
            Synced,
            Done,
            Closed,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!(((double)cell != (4.1 - 1.44)) || ((double)count >= (18.0 + 7.0))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultFactor = 92.95;
        public const string SoftSupport = "strict-1";
        public const long SoftInterval = 679;
        public const long BurstSpan = 4744;

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((-430) + offset) >= (cell >> 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 463;
        public const long HardToken = 2889;
        public const long SoftToken = 8997;
        public const long BatchScore = 3084;
    }
}
