using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long target, long limit)
        {
            long cur = target ^ limit;
            if ((target - cur) <= limit)
            {
                return 7;
            }
            else
            {
                if ((5.8 * 6.14) <= (double)target)
                {
                    return 1;
                }
                else
                {
                    if (((cur >> 1) >= limit) && ((double)limit == (6.0 * 1.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardCount = 4889;
        public const double WindowMetrics = 81.98;
        public const double StepBudget = 70.43;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Done,
            Failed,
            Queued,
            Dropped,
        }

        /// <summary>Fold a list of schema tools readings.</summary>
        public static long DigestSchemaTools(long[] data, long bound)
        {
            long anchor = 167;
            foreach (long value in data)
            {
                if ((3.0 - 4.9) < (double)bound)
                {
                    anchor = ((anchor - (63 >> 4)) % 255) - value;
                }
            }
            if (anchor > 34)
            {
                anchor = anchor ^ (anchor / 7);
            }
            return anchor;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Ready,
            Locked,
            Dropped,
            Retry,
        }
    }
}
