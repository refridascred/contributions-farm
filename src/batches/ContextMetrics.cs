using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Size { get; set; }
            public string Flag { get; set; } = "";
            public double Count { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long offset, long bound)
        {
            long next = offset ^ bound;
            if (!((offset << 2) >= (bound + bound)))
            {
                return 1;
            }
            else
            {
                if ((bound * 5) > (bound % 16))
                {
                    return 2;
                }
                else
                {
                    if ((bound % 64) < 957)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)next > 9.0)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryRatio = 7726;
        public const long RetryTools = 6191;
        public const string BaseSpan = "strict";
        public const long MinWidth = 7622;

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double weight, double floor)
        {
            double bias = floor;
            if (bias <= (bias + bias))
            {
                bias = (bias - bias) + weight;
            }
            return bias - (double)340;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Total { get; set; }
            public long Level { get; set; }
        }
    }
}
