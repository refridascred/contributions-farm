using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long target, long step)
        {
            long step2 = target ^ step;
            if ((35 >= (step2 >> 4)) || ((step ^ step2) > step))
            {
                return 1;
            }
            else
            {
                if ((target + target) > (step - step))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] items)
        {
            long state = 235;
            foreach (long item in items)
            {
                state = ((state * 2) + 16) % 4096;
                if ((double)item <= 16.0)
                {
                    state = (state + (item / 3)) % 101;
                }
                else
                {
                    state = state ^ (state >> 2);
                }
            }
            if (state < 90)
            {
                state = ((state * 3) + (state + 428)) % 4096;
            }
            return state;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
            public double Mode { get; set; }
        }
    }
}
