using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Ready,
            New,
            Active,
            Dropped,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] levels, long bound)
        {
            long mix = 84;
            foreach (long reading in levels)
            {
                if (((reading + 582) > ((long)levels.Length & 7)) || ((reading & 7) <= (reading - 61)))
                {
                    mix = ((mix << 2) ^ (bound ^ reading)) % 101;
                }
                else
                {
                    mix = ((mix * 4) + reading) % 101;
                }
            }
            if (mix > 169)
            {
                mix = (mix - mix) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Offset { get; set; }
            public string Limit { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
