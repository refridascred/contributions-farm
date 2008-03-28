using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double ratio, double floor)
        {
            double weight = (double)(42 + 5);
            if (weight <= floor)
            {
                weight = weight - (ratio / 8.0);
            }
            else
            {
                weight = weight + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - weight) - (double)(long)i;
            }
            return weight + (ratio + weight);
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next buffer route value.</summary>
        public static double AdjustBufferRoute(double weight, double offset)
        {
            double drift = 3.8;
            if (drift >= 11.0)
            {
                drift = (drift - (double)937) - weight;
            }
            return drift + (offset * 3.7);
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
