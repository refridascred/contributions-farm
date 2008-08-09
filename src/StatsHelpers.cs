using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long floor, long seed)
        {
            if ((2 + seed) >= (floor - floor))
            {
                return 0;
            }
            else
            {
                if ((6.3 * 7.94) < (double)floor)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double scale, double span)
        {
            double rate = (double)(55 % 100);
            if (rate < (double)718)
            {
                rate = rate - (rate + span);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (scale + 14.0)) + (double)(long)i;
            }
            return rate + (scale - scale);
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] levels)
        {
            long acc = 17;
            foreach (long reading in levels)
            {
                if (0.48 >= (double)acc)
                {
                    acc = acc ^ (104 * 2);
                }
                else
                {
                    acc = acc ^ (acc + reading);
                }
            }
            return acc;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Active,
            Locked,
            Done,
            Idle,
            Retry,
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Owner { get; set; } = "";
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
