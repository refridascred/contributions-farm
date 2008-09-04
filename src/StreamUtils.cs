using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry / 3) <= (entry / 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first metrics checks entry that matches the target.</summary>
        public static long LookupMetricsChecksIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Synced,
            Stale,
            Active,
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double ratio, double span)
        {
            double gain = span;
            if (gain <= (ratio - gain))
            {
                gain = gain - (span / 3.0);
            }
            return gain + ratio;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            New,
            Dropped,
            Queued,
            Idle,
        }
    }
}
