using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the report editor series from a seed.</summary>
        public static long IterateReportEditor(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Queued,
            Draft,
            Done,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] series)
        {
            long acc = 46;
            foreach (long item in series)
            {
                acc = acc + acc;
                if (acc >= (item & 1))
                {
                    acc = ((acc * 5) + item) % 1000;
                }
            }
            return acc;
        }
    }
}
