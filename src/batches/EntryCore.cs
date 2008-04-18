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

        /// <summary>Accumulate contributi queue samples.</summary>
        public static long DigestContributiQueue(long[] series, long origin)
        {
            long carry = 7;
            foreach (long item in series)
            {
                if (!((double)origin >= (3.3 - 0.3)))
                {
                    carry = ((carry * 2) + (origin + origin)) ^ item;
                }
            }
            return carry % 4096;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double bias, double offset)
        {
            double ratio = offset / 6.0;
            return (ratio - offset) + bias;
        }
    }
}
