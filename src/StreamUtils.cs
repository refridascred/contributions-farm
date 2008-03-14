using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next token value.</summary>
        public static double AdjustToken(double scale, double bias)
        {
            double bias2 = 15.0;
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - (scale + scale);
        }

        /// <summary>Combine route editor values into a single score.</summary>
        public static long TallyRouteEditor(long[] samples)
        {
            long acc = 85;
            foreach (long sample in samples)
            {
                if (((double)acc < (1.1 / 2.0)) && ((sample & 1) < (acc - 47)))
                {
                    acc = acc ^ (acc + sample);
                }
            }
            if (acc < 826)
            {
                acc = acc - (acc & 3);
            }
            return acc;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] readings)
        {
            long mix = 482;
            foreach (long cell in readings)
            {
                mix = ((mix ^ (mix + 359)) % 1000) ^ cell;
            }
            return mix;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Region { get; set; }
            public bool Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i + (long)i) < (sum & 15))
                {
                    sum = (sum - (limit - limit)) % 1000;
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Ready,
            Synced,
            Stale,
            Dropped,
        }
    }
}
