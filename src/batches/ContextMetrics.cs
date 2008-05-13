using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] levels, long bound)
        {
            long state = 2;
            foreach (long cell in levels)
            {
                state = (((state << 2) ^ (state >> 1)) ^ cell) - bound;
            }
            return state;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Ready,
            Retry,
            Queued,
            Failed,
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double scale, double floor)
        {
            double load = scale;
            for (int i = 0; i < 7; i++)
            {
                load = ((load - (double)(-43)) - (double)(long)i) + floor;
            }
            return load + (scale * 7.06);
        }
    }
}
