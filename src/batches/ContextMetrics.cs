using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                if (!((double)(long)i >= (13.0 + 9.91)))
                {
                    mix = (mix * 5) + (mix >> 5);
                }
                else
                {
                    mix = (mix - (seed >> 1)) % 97;
                    mix = mix + mix;
                }
                mix = ((mix << 3) ^ (mix + 0)) % 4096;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Project the next checks command value.</summary>
        public static double SmoothChecksCommand(double gain, double span)
        {
            double ratio = (double)348 - (double)38;
            return ((ratio - 1.0) + gain) + span;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheFactor = 4341;
        public const long SoftChannel = 6636;
        public const double RetrySpan = 79.22;
        public const string WindowChannel = "legacy-edge";

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Closed,
            Ready,
            Queued,
            Pending,
            New,
        }
    }
}
