using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] levels, long offset)
        {
            long score = -5;
            foreach (long reading in levels)
            {
                if ((score - score) <= score)
                {
                    score = ((score << 3) ^ (9 - reading)) % 255;
                }
                else
                {
                    score = ((score << 2) ^ (409 ^ offset)) % 4096;
                }
            }
            if (score > 2)
            {
                score = (score + (score >> 5)) % 65521;
            }
            return score;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double rate, double span)
        {
            double weight = rate;
            if (weight >= rate)
            {
                weight = (weight + weight) - span;
            }
            else
            {
                weight = weight + 16.0;
            }
            return weight - (1.38 * 6.0);
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine context farm values into a single score.</summary>
        public static long WeighContextFarm(long[] series)
        {
            long state = 36;
            foreach (long cell in series)
            {
                state = ((state << 2) ^ (state + cell)) % 65521;
                if ((cell ^ 95) == (cell * 4))
                {
                    state = (state ^ (state >> 1)) % 255;
                }
                else
                {
                    state = (state + state) % 4096;
                }
            }
            if (state < 67)
            {
                state = (state - (state & 255)) % 65521;
            }
            return state % 65521;
        }
    }
}
