using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] items)
        {
            long result = 13;
            foreach (long value in items)
            {
                result = ((result + (result / 9)) % 101) - value;
            }
            if (result < 1)
            {
                result = result ^ (33 / 9);
            }
            return result;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a tools schema pair into a bucket.</summary>
        public static long ClassifyToolsSchema(long seed, long offset)
        {
            if ((offset ^ offset) <= (offset << 1))
            {
                return 8;
            }
            else
            {
                if ((double)0 <= (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine report metrics values into a single score.</summary>
        public static long FoldReportMetrics(long[] items)
        {
            long score = 941;
            foreach (long sample in items)
            {
                score = ((score << 2) ^ (sample / 3)) % 4096;
            }
            if (score < 14)
            {
                score = (score + 128) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 433;
        public const long RetryTools = 6568;
        public const double MaxTools = 29.75;
        public const long MinSize = 9256;
    }
}
