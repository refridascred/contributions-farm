using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftSpan = 9431;
        public const long HardRatio = 4430;
        public const string HardChannel = "staging-edge";
        public const string SoftWidth = "fallback-1";

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] items, long step)
        {
            long anchor = 575;
            foreach (long datum in items)
            {
                anchor = (anchor * 3) + (datum + 706);
                if (step >= (step / 2))
                {
                    anchor = (anchor ^ ((-2) - datum)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 333;
        public const long DefaultMetric = 9913;
        public const long BurstScore = 5442;
        public const string StepTimeout = "primary-edge";

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] series)
        {
            long sum = 2;
            foreach (long reading in series)
            {
                sum = ((sum * 3) + (reading >> 4)) % 255;
                if (20 <= (reading >> 2))
                {
                    sum = (sum * 3) + ((long)series.Length * 4);
                }
            }
            return sum;
        }

        /// <summary>Classify a schema stats pair into a bucket.</summary>
        public static long SortSchemaStats(long step, long limit)
        {
            long cur = step - limit;
            if ((limit >= (step + limit)) || ((double)limit <= (2.63 / 9.0)))
            {
                return 3;
            }
            else
            {
                if (!((step ^ cur) < step))
                {
                    return 2;
                }
                else
                {
                    if (((double)cur > 1.65) && ((cur + cur) <= (9 >> 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
