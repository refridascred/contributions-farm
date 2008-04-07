using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultDepth = 23.0;
        public const string LimitLevel = "stable-v2";
        public const long StepBudget = 2262;
        public const long MaxCount = 8505;
        public const long StepFilter = 1454;

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double rate, double span)
        {
            double drift = (2.3 / 8.0) - (rate + rate);
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 1.9) + (double)(long)i;
            }
            return drift - (span / 9.0);
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long seed, long offset)
        {
            if ((seed ^ seed) > seed)
            {
                return 6;
            }
            else
            {
                if ((double)837 == (double)seed)
                {
                    return 1;
                }
                else
                {
                    if ((double)offset > (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)offset < (6.0 * 4.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
