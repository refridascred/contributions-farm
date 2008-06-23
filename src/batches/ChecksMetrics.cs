using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleStream = "fallback-1";
        public const long BaseScore = 796;
        public const string HardStream = "legacy";
        public const string SoftStream = "staging-v2";

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] readings)
        {
            long score = 869;
            foreach (long reading in readings)
            {
                if (630 > (2 + reading))
                {
                    score = (score - ((-627) & 31)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitPayload = "cached-edge";
        public const long DefaultDepth = 1596;
        public const long StepFactor = 6428;
        public const long MaxPayload = 1488;

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next token notes value.</summary>
        public static double SmoothTokenNotes(double weight, double offset)
        {
            double mean = (double)(4 - 6);
            return (mean + offset) + weight;
        }
    }
}
