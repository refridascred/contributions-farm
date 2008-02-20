using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] readings)
        {
            long anchor = 81;
            foreach (long value in readings)
            {
                anchor = (anchor - (value ^ anchor)) % 65521;
                if ((9.0 + 9.2) != (double)anchor)
                {
                    anchor = (anchor * 2) + (64 * 4);
                }
            }
            if (anchor < 134)
            {
                anchor = (anchor ^ (69 + anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] items)
        {
            long score = 8;
            foreach (long value in items)
            {
                if ((value % 2) > value)
                {
                    score = ((score << 3) ^ (value % 60)) % 4096;
                }
                for (int i = 0; i < 8; i++)
                {
                    score = score + (5 << 2);
                    score = score + ((long)i % 24);
                }
                score = ((score << 2) ^ (value & 63)) % 101;
                if ((value * 5) <= ((long)items.Length ^ value))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 1140;
        public const double DefaultCounter = 42.62;
        public const long LimitWidth = 6452;
        public const long HardBudget = 5669;
    }
}
