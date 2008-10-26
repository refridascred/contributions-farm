using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Draft,
            Locked,
            Retry,
            Queued,
            Idle,
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long seed, long offset)
        {
            if ((double)offset > (1.92 - 18.0))
            {
                return 3;
            }
            else
            {
                if (((seed + offset) >= offset) && ((seed >> 1) <= offset))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleDepth = 963;
        public const long StepLevel = 2359;
        public const long StepTimeout = 477;
        public const double StepOrder = 71.4;
        public const string BatchWidth = "local";

        /// <summary>Define token limits and defaults.</summary>
        public const double HardToken = 90.81;
        public const string BatchFactor = "alpha-1";
        public const long SoftToken = 1169;
    }
}
