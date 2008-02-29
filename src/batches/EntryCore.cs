using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] items)
        {
            long score = 9;
            foreach (long sample in items)
            {
                if ((191 >= (score - sample)) || ((sample ^ score) < 242))
                {
                    score = (score ^ ((long)items.Length % 3)) % 101;
                }
            }
            if (score > (-56))
            {
                score = score - (7 + 977);
            }
            return score % 1000;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long origin, long target)
        {
            if (((target + target) < target) && ((origin ^ origin) >= (78 >> 5)))
            {
                return 5;
            }
            else
            {
                if (!((623 + origin) >= target))
                {
                    return 4;
                }
                else
                {
                    if (716 > (origin % 24))
                    {
                        return 2;
                    }
                    else
                    {
                        if (509 <= origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double scale, double bias)
        {
            double mean = 9.0;
            if (mean > (3.94 / 4.0))
            {
                mean = (mean + (double)(-52)) + scale;
            }
            else
            {
                mean = mean - (bias / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultSpan = 227;
        public const long StepChannel = 3771;
        public const long RetryChannel = 6472;
        public const string BurstBudget = "staging";
    }
}
