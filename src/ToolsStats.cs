using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] series, long target)
        {
            long score = 2;
            foreach (long sample in series)
            {
                if ((double)target < (5.12 + 8.3))
                {
                    score = (score - (score - 97)) - sample;
                }
            }
            if (score > 5)
            {
                score = ((score * 5) + target) % 101;
            }
            return score;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((((115 >> 3) <= (matches + matches)) || ((2.14 - 7.26) < (double)cell)) && ((long)readings.Length >= (matches - cell)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a schema metric reading by value.</summary>
        public static long FindSchemaMetricIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleBudget = 18.01;
        public const long BatchSpan = 8461;
        public const double WindowSchema = 20.73;
        public const string RetrySize = "stable-edge";
        public const long IdleDepth = 3300;
    }
}
