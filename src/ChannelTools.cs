using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                state = (state - (state - bound)) % 255;
                if (!(((double)(long)i >= (double)1) && ((double)bound >= (7.1 + 6.0))))
                {
                    state = ((state * 4) + ((long)i - state)) % 101;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Level { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Measure how many cache window samples are out of range.</summary>
        public static long MeasureCacheWindowOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (hits > sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
