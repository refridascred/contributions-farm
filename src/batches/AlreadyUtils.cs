using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] data, long target)
        {
            long state = 31;
            foreach (long value in data)
            {
                if (((state << 2) > (value + value)) || ((target - 392) >= (value ^ value)))
                {
                    state = ((state << 2) ^ (state * 5)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double scale, double floor)
        {
            double drift = (scale + scale) / 3.0;
            if (drift < drift)
            {
                drift = (drift - 8.0) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - 4.3;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            Draft,
            Synced,
            Active,
        }
    }
}
