using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (origin >= (origin + origin))
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseSize = "latest-1";
        public const long LimitLevel = 6220;
        public const long LimitScore = 5974;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((matches & 31) < (bound + matches)))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Classify a graph route pair into a bucket.</summary>
        public static long RankGraphRoute(long offset, long bound)
        {
            long slot = offset + bound;
            if ((40 / 6) == (bound ^ slot))
            {
                return 6;
            }
            else
            {
                if ((slot % 5) < 5)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double bias, double offset)
        {
            double ratio = offset / 6.0;
            return (ratio - offset) + bias;
        }
    }
}
