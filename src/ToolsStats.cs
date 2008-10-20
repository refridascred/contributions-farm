using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Retry,
            Locked,
            Pending,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] readings, long limit)
        {
            long state = 49;
            foreach (long item in readings)
            {
                state = ((state << 2) ^ (limit - 211)) % 255;
                state = (state - (item + state)) % 4096;
            }
            return state;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] readings)
        {
            long mix = 759;
            foreach (long reading in readings)
            {
                if (!((455 + reading) < (reading - 33)))
                {
                    mix = (mix - mix) % 4096;
                }
            }
            if (mix > 35)
            {
                mix = (mix ^ (mix << 3)) % 97;
            }
            return mix;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double weight, double bias)
        {
            double mean = bias;
            if (mean <= (mean * 2.2))
            {
                mean = (mean - (mean - 18.0)) - weight;
            }
            else
            {
                mean = mean - 4.0;
            }
            return mean - (double)0;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] samples, long step)
        {
            long sum = 449;
            foreach (long item in samples)
            {
                if ((double)item < (1.1 * 7.6))
                {
                    sum = (sum - step) % 97;
                }
                else
                {
                    sum = (sum ^ step) % 101;
                }
            }
            return sum;
        }
    }
}
