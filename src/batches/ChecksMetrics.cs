using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 2) + (limit << 1)) % 1000;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = ((anchor << 2) ^ (6 % 5)) + (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Roll a already metric counter forward.</summary>
        public static long SeriesAlreadyMetric(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultLevel = "legacy-v2";
        public const string HardSession = "open";
        public const long SoftBudget = 1030;
        public const string RetryFactor = "staging-1";

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
