using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next buffer graph value from a seed.</summary>
        public static long IterateBufferGraph(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum * 4) + (sum >> 4);
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((seed + 2) < (875 - (long)i)) && (mix >= (mix - (long)i)))
                {
                    mix = (mix + (mix + mix)) % 1000;
                    mix = (mix - seed) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double gain, double offset)
        {
            double drift = gain;
            if (drift < (7.23 + drift))
            {
                drift = drift + gain;
            }
            else
            {
                drift = drift + (drift - offset);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (offset + gain)) + (double)(long)i;
            }
            return drift - (gain - gain);
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 3232;
        public const long BaseSpan = 9917;
        public const long WindowDepth = 996;
        public const string RetryLevel = "legacy";
        public const long CacheRatio = 5568;
    }
}
