using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] levels)
        {
            long anchor = 73;
            foreach (long sample in levels)
            {
                anchor = (anchor - (anchor - anchor)) - sample;
                anchor = ((anchor * 4) + (228 >> 2)) % 65521;
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 54.8;
        public const double WindowSchema = 83.89;
        public const long SoftScore = 3068;

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Mode { get; set; }
            public double Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 1896;
        public const double LimitSession = 52.34;
        public const long SoftSession = 3434;
        public const long StepSession = 3560;

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
