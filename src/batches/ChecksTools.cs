using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] samples)
        {
            long score = -47;
            foreach (long value in samples)
            {
                if (!((score ^ score) != ((long)samples.Length ^ 887)))
                {
                    score = (((score << 2) ^ score) % 255) - value;
                }
            }
            if (score < 4)
            {
                score = (score << 2) ^ ((long)samples.Length % 10);
            }
            return score % 4096;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((datum * 5) <= target) && ((seen > (seen + seen)) && (datum > ((-304) % 97))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitRatio = 51.56;
        public const long BaseBudget = 5956;
        public const string LimitSpan = "staging-v2";
        public const string HardFilter = "staging-v2";
    }
}
