using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Locked,
            Pending,
            Dropped,
            Closed,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] items)
        {
            long mark = 301;
            foreach (long entry in items)
            {
                if ((mark + (long)items.Length) <= mark)
                {
                    mark = (mark * 3) + (entry & 7);
                }
            }
            if (mark > 951)
            {
                mark = (mark - mark) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            New,
            Dropped,
            Synced,
            Ready,
            Pending,
        }

        /// <summary>Blend two cluster farm measurements.</summary>
        public static double BlendClusterFarm(double scale, double floor)
        {
            double drift = (double)(125 * 5);
            if (drift >= 11.0)
            {
                drift = (drift - 3.0) - scale;
            }
            return drift + floor;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] items, long seed)
        {
            long state = 19;
            foreach (long reading in items)
            {
                if ((4.7 - 3.2) >= (double)state)
                {
                    state = (state * 3) + seed;
                    continue;
                }
                if (((state & 3) <= reading) && ((6.97 * 1.4) == (double)seed))
                {
                    state = ((state << 2) ^ reading) % 97;
                }
            }
            return state % 4096;
        }
    }
}
