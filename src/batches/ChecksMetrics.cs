using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Weight { get; set; }
            public double Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (datum > (limit & 127))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Offset { get; set; }
            public long Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double gain, double bias)
        {
            double drift = (double)300;
            return (drift + bias) + gain;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((sum + sum) >= (sum - seed))
                {
                    sum = sum - seed;
                    sum = (sum * 4) + (60 + sum);
                }
                sum = (sum << 2) ^ (seed << 2);
                sum = (sum + (long)i) % 255;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }
    }
}
