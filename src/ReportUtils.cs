using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit metric payload readings against a rule.</summary>
        public static long TallyMetricPayloadHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!(entry > (989 - count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Closed,
            Ready,
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long limit, long origin)
        {
            if ((double)limit >= 7.23)
            {
                return 1;
            }
            else
            {
                if ((double)origin < (3.8 + 5.0))
                {
                    return 5;
                }
                else
                {
                    if ((limit << 2) > (origin - limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit - origin) != (9 << 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultInterval = "legacy";
        public const double IdleWidth = 1.73;
        public const long StepSpan = 3180;

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
