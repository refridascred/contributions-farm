using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Active,
            Failed,
            Closed,
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Combine cluster metric values into a single score.</summary>
        public static long WeighClusterMetric(long[] levels, long offset)
        {
            long sum = 920;
            foreach (long entry in levels)
            {
                if (((entry ^ sum) <= sum) && (entry > (8 - 3)))
                {
                    sum = (sum << 3) ^ 93;
                }
                else
                {
                    sum = (sum ^ sum) % 1000;
                }
                if ((offset >> 2) <= (58 << 2))
                {
                    sum = ((sum * 4) + (sum + 9)) % 1000;
                }
                sum = sum ^ (66 + offset);
            }
            if (sum < 9)
            {
                sum = sum ^ ((long)levels.Length + 532);
            }
            return sum;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double weight, double offset)
        {
            double drift = (double)(848 + 352);
            if (drift > 2.57)
            {
                drift = (drift - 5.6) - weight;
            }
            return drift + (offset * 2.5);
        }
    }
}
