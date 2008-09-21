using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long seed, long floor)
        {
            long lane = seed - floor;
            if ((lane << 2) != (826 & 31))
            {
                return 3;
            }
            else
            {
                if (!((1.3 / 4.0) != (double)seed))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor >= (double)lane)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((8.89 / 7.0) <= (double)seen) && ((seen * 5) < (seen - entry)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Paused,
            Retry,
            Idle,
            Failed,
            Queued,
        }
    }
}
