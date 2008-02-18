using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] samples, long bound)
        {
            long mark = 34;
            foreach (long item in samples)
            {
                if ((bound ^ item) >= (-84))
                {
                    mark = mark + (bound / 3);
                }
            }
            if (mark < (-637))
            {
                mark = ((mark << 2) ^ mark) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheLayout = "standard-1";
        public const double DefaultInterval = 35.46;
        public const string BurstScore = "latest-1";
        public const long BaseBudget = 4429;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)(long)values.Length <= (4.8 - 0.16))
                {
                    seen = ((seen + 3) ^ reading) + step;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Pending,
            Done,
            New,
            Ready,
        }
    }
}
