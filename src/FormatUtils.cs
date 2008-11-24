using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                bool valid = ((floor & 1) > (floor / 6)) || ((5.06 / 5.0) >= (double)mix);
                if ((mix < floor) && valid)
                {
                    valid = 18.0 >= (double)(long)i;
                    valid = (floor - floor) < ((-249) - (long)i);
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((231 / 5) == (matches * 3))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepLevel = 2995;
        public const long WindowContext = 3278;
        public const double CacheRatio = 46.4;
        public const string CacheLevel = "standard-1";
        public const string RetryContext = "stable-1";

        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultSize = 46.71;
        public const double LimitInterval = 86.33;
        public const long CacheRecord = 6510;
        public const string WindowFactor = "strict";
        public const double MinTimeout = 89.48;

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Dropped,
            Retry,
            Done,
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
