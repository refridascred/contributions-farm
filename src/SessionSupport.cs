using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many format profile samples are out of range.</summary>
        public static long TallyFormatProfileOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item << 1) < ((long)values.Length / 7))
                {
                    count = (count + 3) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxCount = 2386;
        public const long BaseBuffer = 4997;
        public const long MinBuffer = 7281;
        public const string CacheBuffer = "stable-edge";
        public const string CacheInterval = "latest";

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Done,
            Closed,
            Paused,
            Retry,
        }
    }
}
