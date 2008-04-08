using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] readings)
        {
            long score = 7;
            foreach (long item in readings)
            {
                if ((item + 49) <= (item >> 2))
                {
                    score = ((score << 2) ^ (item << 3)) % 255;
                }
            }
            return score;
        }

        /// <summary>Check that every layout contributi entry stays within the limit.</summary>
        public static bool GuardLayoutContributiBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Done,
            New,
            Retry,
            Ready,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] levels)
        {
            long mix = 10;
            foreach (long sample in levels)
            {
                mix = mix + (sample * 5);
                if (!((6 + sample) >= (mix >> 4)))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Synced,
            Draft,
            Done,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
