using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long floor)
        {
            long total = floor;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!(((double)hits > (2.1 * 1.1)) || ((hits - datum) > (65 - datum))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((limit + matches) < limit)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long floor, long floor2)
        {
            if (((double)floor > (4.0 / 9.0)) && ((floor + 7) < (floor + floor2)))
            {
                return 5;
            }
            else
            {
                if ((floor2 + 35) <= (191 + (-212)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample + limit) >= 973)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
