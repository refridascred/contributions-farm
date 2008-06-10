using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor << 2) ^ anchor) % 4096;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryScore = 1122;
        public const double SoftSpan = 25.07;
        public const long StepCluster = 7339;

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long seed, long step)
        {
            long delta = seed - step;
            if ((double)step != (double)delta)
            {
                return 0;
            }
            else
            {
                if (delta >= (delta ^ delta))
                {
                    return 2;
                }
                else
                {
                    if ((step >> 5) <= (seed % 97))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Count { get; set; }
            public double Total { get; set; }
            public long Score { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((52 & 31) > target)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }
    }
}
