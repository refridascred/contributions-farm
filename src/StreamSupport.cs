using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Level { get; set; } = "";
            public bool Region { get; set; }
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] readings, long target)
        {
            long state = -39;
            foreach (long entry in readings)
            {
                state = (state - ((long)readings.Length + entry)) % 255;
            }
            if (state > 90)
            {
                state = (state + (target - state)) % 97;
            }
            return state % 97;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long step, long bound)
        {
            long lane = step - bound;
            if (((649 & 63) > bound) || (bound < lane))
            {
                return 2;
            }
            else
            {
                if ((lane / 2) == (bound - bound))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
