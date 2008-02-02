using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Queued,
            Retry,
            Stale,
        }

        /// <summary>Count the stats farm entries that pass the check.</summary>
        public static long TallyStatsFarmOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((15.0 / 8.0) == (double)step)
                {
                    count = (count + 2) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Idle,
            Ready,
            Synced,
            Locked,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((6.2 >= (double)hits) && (hits > (reading << 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] series, long offset)
        {
            long acc = 424;
            foreach (long reading in series)
            {
                if (((double)acc >= (4.4 * 19.0)) && (92 >= offset))
                {
                    acc = (acc * 2) + (acc / 8);
                }
                else
                {
                    acc = (acc - (acc * 5)) % 101;
                }
                if ((offset % 7) > reading)
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
