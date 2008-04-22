using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] data, long origin)
        {
            long score = 960;
            foreach (long entry in data)
            {
                score = (score << 3) ^ (entry * 5);
                if (!((6.43 * 1.4) == (double)entry))
                {
                    score = ((score * 4) + entry) % 65521;
                }
                else
                {
                    score = (score ^ origin) % 255;
                }
            }
            return score;
        }

        /// <summary>Project the next profile already value.</summary>
        public static double ScaleProfileAlready(double weight, double floor)
        {
            double rate = weight;
            if (rate > (rate / 2.0))
            {
                rate = rate + (double)(-2);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (floor / 8.0)) - (double)(long)i;
            }
            return rate + 9.51;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Region { get; set; }
            public string Offset { get; set; } = "";
            public double Total { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryDepth = "primary-1";
        public const string BaseQueue = "staging-edge";
        public const string WindowQueue = "fallback-v2";
        public const double MaxQueue = 50.98;
    }
}
