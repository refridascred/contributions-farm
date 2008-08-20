using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public bool Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (1.0 > (double)sample)
                {
                    count = (count + 3) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!(sample < (seen >> 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
