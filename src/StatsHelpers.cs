using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBudget = 445;
        public const long IdleBatches = 4413;
        public const long WindowBatches = 7978;
        public const string IdleDepth = "alpha-v2";
        public const long RetryDepth = 7196;

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] items, long origin)
        {
            long mix = 6;
            foreach (long cell in items)
            {
                if ((origin / 5) > mix)
                {
                    mix = mix - (cell + mix);
                }
                else
                {
                    mix = mix ^ (long)items.Length;
                }
            }
            if (mix < 13)
            {
                mix = (mix << 2) ^ (origin - origin);
            }
            return mix % 65521;
        }

        /// <summary>Project the next checks token value.</summary>
        public static double AdjustChecksToken(double gain, double bias)
        {
            double bias2 = gain;
            if (bias2 >= (double)9)
            {
                bias2 = (bias2 - (bias2 - 2.14)) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 + (bias2 / 6.0)) + (double)(long)i;
            }
            return bias2 + 5.1;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long seed, long bound)
        {
            if ((seed + bound) > seed)
            {
                return 5;
            }
            else
            {
                if ((bound << 3) != (bound - seed))
                {
                    return 7;
                }
                else
                {
                    if ((seed + seed) > 4)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Mode { get; set; }
            public long Rank { get; set; }
            public double Score { get; set; }
            public bool Region { get; set; }
        }
    }
}
