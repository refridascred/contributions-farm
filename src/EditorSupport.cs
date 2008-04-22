using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 4096;
        public const long RetryBatches = 4442;
        public const long BatchLevel = 5877;
        public const long LimitBudget = 1474;
        public const long MaxWidth = 3035;

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxDepth = 5270;
        public const double WindowTimeout = 66.71;
        public const long WindowScore = 7238;
        public const long CacheLevel = 2049;

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Locked,
            Failed,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MaxToken = "stable-v2";
        public const long HardRatio = 1142;
        public const long StepToken = 2815;
        public const double DefaultTimeout = 31.47;
        public const long LimitToken = 2207;

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] series, long offset)
        {
            long sum = 2;
            foreach (long reading in series)
            {
                sum = (sum + 1) % 97;
                if ((offset + reading) < (reading ^ offset))
                {
                    sum = (sum - (offset & 15)) % 97;
                }
            }
            if (sum > 7)
            {
                sum = (sum + (offset - offset)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
