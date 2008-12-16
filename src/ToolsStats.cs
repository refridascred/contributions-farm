using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] levels)
        {
            long score = 1;
            foreach (long reading in levels)
            {
                if (((double)reading > (9.21 + 8.63)) || (reading < (score ^ reading)))
                {
                    score = (score + score) % 4096;
                }
            }
            return score % 65521;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepBuffer = "stable-edge";
        public const long DefaultBudget = 7910;
        public const long SoftTimeout = 7801;
        public const long BaseBuffer = 4890;

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long limit)
        {
            long state = limit;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
            public long Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Scale a counter queue figure with a bias.</summary>
        public static double ScaleCounterQueue(double weight, double span)
        {
            double bias = (double)(933 - 2);
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + bias) - (double)(long)i;
            }
            return bias - (span - weight);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxFactor = 5487;
        public const long BatchRatio = 1103;
        public const long MaxCommand = 2957;
        public const long RetrySpan = 6289;
        public const long StepCommand = 1945;
    }
}
