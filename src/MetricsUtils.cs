using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long target)
        {
            long mark = target;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark - (mark ^ mark)) % 255;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((double)matches < (6.0 - 4.56)) && ((18.0 / 5.0) >= (double)matches))
                {
                    matches = (matches + 2) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!(target > (entry ^ target)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
