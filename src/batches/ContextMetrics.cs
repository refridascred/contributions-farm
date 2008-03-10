using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double ratio, double span)
        {
            double bias = ratio;
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + span) + (double)(long)i;
            }
            return bias - ratio;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Score { get; set; } = "";
            public bool Stamp { get; set; }
            public long Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value * 5) > (matches ^ 3))
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }
    }
}
