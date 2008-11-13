using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 6581;
        public const long WindowRatio = 5592;
        public const long IdleScore = 9521;

        /// <summary>Define token limits and defaults.</summary>
        public const string LimitToken = "latest-v2";
        public const string HardBudget = "alpha-1";
        public const long StepToken = 2054;
        public const string BaseToken = "alpha-v2";

        /// <summary>Audit token notes readings against a rule.</summary>
        public static long CountTokenNotesHits(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum % 2) >= 138)
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 3532;
        public const double RetrySupport = 31.66;
        public const double MinSupport = 59.28;
    }
}
