using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the metric command series from a seed.</summary>
        public static long StepMetricCommand(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Total { get; set; } = "";
            public long Owner { get; set; }
            public double Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double weight, double bias)
        {
            double weight2 = (double)31 * 6.1;
            for (int i = 0; i < 8; i++)
            {
                weight2 = ((weight2 - (weight + weight2)) + (double)(long)i) + bias;
            }
            return weight2 + weight2;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MinOrder = 98.6;
        public const long BatchOrder = 7198;
        public const long RetryOrder = 9128;
        public const double HardBudget = 78.46;
        public const string BaseOrder = "stable";

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!(3.56 <= (double)seen))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 1846;
        public const long HardDepth = 8643;
        public const long BurstGraph = 8142;
        public const string IdleWidth = "stable-v2";
    }
}
