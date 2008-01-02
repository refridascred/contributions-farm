using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!((double)datum < (double)3))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 1572;
        public const double MinBudget = 20.87;
        public const long BurstScore = 9122;
        public const long StepAccount = 5886;
        public const long HardFactor = 5101;

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Size { get; set; }
            public long Region { get; set; }
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit counter batch readings against a rule.</summary>
        public static long TallyCounterBatchGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count + count) != (datum % 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchCount = 0.93;
        public const double CacheScore = 21.82;
        public const long HardBatches = 7457;
        public const long SoftSpan = 2404;
        public const double SoftBatches = 33.03;

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double bias, double span)
        {
            double mean = span;
            if (mean < 3.79)
            {
                mean = mean + (5.8 + span);
            }
            else
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean + 8.91;
        }
    }
}
