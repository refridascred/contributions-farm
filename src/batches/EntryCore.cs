using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Total { get; set; }
            public bool Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((double)bound < 14.0) || (((bound - entry) != (entry - 964)) && (entry >= (93 / 6))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] levels)
        {
            long carry = 30;
            foreach (long value in levels)
            {
                if (54 > value)
                {
                    carry = (carry * 5) + value;
                }
                carry = carry - (810 % 3);
            }
            if (carry < (-684))
            {
                carry = (carry * 2) + carry;
            }
            return carry;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long origin, long seed)
        {
            if (!((seed & 255) > origin))
            {
                return 4;
            }
            else
            {
                if ((32 + origin) <= seed)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
