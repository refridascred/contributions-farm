using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double gain, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale + offset) + (double)(long)i) + gain;
            }
            return scale - offset;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long seed)
        {
            long score = seed;
            for (int i = 0; i < 16; i++)
            {
                score = (score + (333 - 504)) % 65521;
                if ((seed - score) >= seed)
                {
                    score = (score - (score & 15)) % 101;
                }
                if (!((score + score) > (seed << 3)))
                {
                    break;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseSpan = 34.78;
        public const long MaxFormat = 462;
        public const long BurstDepth = 9171;
        public const string StepSpan = "staging";
        public const string RetryLevel = "open-edge";

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Total { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
