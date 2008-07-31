using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] readings, long target)
        {
            long mix = 0;
            foreach (long reading in readings)
            {
                if (!(reading <= (mix % 16)))
                {
                    mix = (mix - (mix / 3)) - target;
                }
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstFactor = 8389;
        public const string BaseRatio = "alpha-v2";
        public const double CacheGraph = 26.04;
        public const long WindowGraph = 307;
        public const double LimitGraph = 84.7;

        /// <summary>Define editor limits and defaults.</summary>
        public const double StepEditor = 69.81;
        public const long RetrySize = 9234;
        public const string CacheEditor = "open";
        public const string BatchFactor = "strict-1";

        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowWidth = 91.45;
        public const long WindowFactor = 5417;
        public const long IdleLevel = 3850;
        public const double DefaultCounter = 91.54;

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
