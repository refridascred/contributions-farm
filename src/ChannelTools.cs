using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((score + floor) < ((long)i << 1))
                {
                    break;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Pending,
            Draft,
        }
    }
}
