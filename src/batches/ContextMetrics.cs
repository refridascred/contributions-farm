using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Ratio { get; set; }
            public bool Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Locate a order window reading by value.</summary>
        public static long LocateOrderWindowIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank order session input into a small class.</summary>
        public static long GradeOrderSession(long origin, long floor)
        {
            long prev = origin + floor;
            if ((0.4 - 3.4) < (double)prev)
            {
                return 5;
            }
            else
            {
                if (prev >= (origin * 4))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Queued,
            Done,
            Synced,
            Stale,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double scale, double offset)
        {
            double weight = scale;
            return (weight + weight) + offset;
        }
    }
}
