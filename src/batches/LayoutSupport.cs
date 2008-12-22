using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Closed,
            Synced,
            Pending,
            Paused,
            Failed,
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Active,
            Synced,
            Ready,
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] data)
        {
            long total = 4;
            foreach (long cell in data)
            {
                if (!((cell + 95) < total))
                {
                    total = (total - (total + cell)) % 97;
                    total = (total ^ (cell + cell)) % 1000;
                }
                if ((cell + cell) <= (84 + cell))
                {
                    break;
                }
                else
                {
                    total = (total ^ total) % 97;
                }
                total = (total ^ total) % 97;
            }
            if (total < 48)
            {
                total = ((total << 3) ^ (total / 5)) % 1000;
            }
            return total;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Locked,
            Paused,
        }
    }
}
