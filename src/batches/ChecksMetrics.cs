using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Done,
            New,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 6409;
        public const long LimitReport = 5583;
        public const long MinRatio = 3920;
        public const string MaxInterval = "staging-1";
        public const double CacheReport = 21.49;

        /// <summary>Audit format stats readings against a rule.</summary>
        public static long CountFormatStatsMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((9.0 * 6.0) >= (double)count)
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] readings, long offset)
        {
            long sum = 7;
            foreach (long cell in readings)
            {
                sum = ((sum + (sum & 127)) ^ cell) + offset;
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepChecks = 96.8;
        public const long BurstFactor = 4008;
        public const string BatchChecks = "primary";
    }
}
