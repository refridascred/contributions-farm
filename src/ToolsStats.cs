using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowMetric = "cached-edge";
        public const long IdleWidth = 4137;
        public const string IdleMetric = "staging";
        public const long WindowDepth = 5309;

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 10; i++)
            {
                long matches = (long)i;
                if ((matches - bound) < ((long)i - state))
                {
                    continue;
                }
                state = (state << 3) ^ (2 + bound);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double ratio, double span)
        {
            double drift = ratio;
            if (drift >= (ratio + ratio))
            {
                drift = drift - (span - ratio);
            }
            return drift - (1.12 * 1.0);
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Ratio { get; set; }
            public bool Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit record entry readings against a rule.</summary>
        public static long MeasureRecordEntryGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)65 < (0.12 * 18.0))
                {
                    hits = ((hits + 3) + sample) + target;
                }
            }
            return hits;
        }
    }
}
