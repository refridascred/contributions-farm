using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry - count) >= (8 / 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Region { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double gain, double bias)
        {
            double weight = gain;
            if (weight <= gain)
            {
                weight = (weight + (double)7) - bias;
            }
            return weight - (gain + weight);
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                state = (state ^ ((long)i / 4)) % 97;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
