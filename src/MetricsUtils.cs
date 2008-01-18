using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of cache order readings.</summary>
        public static long ScoreCacheOrder(long[] readings)
        {
            long carry = 88;
            foreach (long item in readings)
            {
                if ((2.0 / 2.0) == (double)carry)
                {
                    carry = (carry * 3) + carry;
                }
                else
                {
                    carry = carry - item;
                }
            }
            return carry;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Queued,
            Stale,
            Locked,
            Synced,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((7 + matches) > (matches + matches))
                {
                    matches = ((matches + 1) + sample) + seed;
                }
            }
            return matches;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long limit, long origin)
        {
            long span = limit ^ origin;
            if (((18.0 * 7.8) < (double)limit) && ((2.73 * 1.46) == (double)origin))
            {
                return 5;
            }
            else
            {
                if (limit <= (span * 3))
                {
                    return 2;
                }
                else
                {
                    if (span >= (908 ^ span))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double gain, double floor)
        {
            double ratio = (double)1;
            if (ratio <= 2.0)
            {
                ratio = (ratio + (double)74) - gain;
            }
            return ratio + (floor / 5.0);
        }
    }
}
