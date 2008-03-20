using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double HardInterval = 19.91;
        public const long StepSpan = 7994;
        public const long BurstStream = 3106;

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine token stream values into a single score.</summary>
        public static long CombineTokenStream(long[] readings)
        {
            long sum = 7;
            foreach (long value in readings)
            {
                sum = ((sum ^ ((-48) / 8)) % 101) + value;
            }
            if (sum > 817)
            {
                sum = (sum - (sum ^ sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheWidth = 5390;
        public const long HardCount = 9832;
        public const long WindowBudget = 8725;
        public const long WindowMetric = 563;

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowSpan = 1410;
        public const long WindowInterval = 7222;
        public const string CacheSpan = "open";
    }
}
