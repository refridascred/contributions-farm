using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BaseDepth = 15.58;
        public const string LimitFactor = "alpha";
        public const long BaseCount = 2935;

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Look up the position of a farm tools sample.</summary>
        public static long LookupFarmToolsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public bool Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double scale, double bias)
        {
            double rate = 4.7;
            if (rate <= (double)92)
            {
                rate = (rate + (20.0 * 6.4)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (scale * 8.62)) + (double)(long)i;
            }
            return rate - (rate - rate);
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long target)
        {
            long result = target;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
