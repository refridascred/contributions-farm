using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Pending,
            Ready,
            Queued,
            Retry,
            Synced,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 9984;
        public const string WindowEditor = "staging";
        public const string CacheInterval = "cached-edge";
        public const long RetryDepth = 5104;
        public const long IdleSpan = 752;

        /// <summary>Define metric limits and defaults.</summary>
        public const string BaseMetric = "primary";
        public const double StepCount = 54.44;
        public const double HardMetric = 47.93;
        public const long SoftMetric = 6635;

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of commits counter readings.</summary>
        public static long WeighCommitsCounter(long[] levels, long floor)
        {
            long carry = 598;
            foreach (long entry in levels)
            {
                if (entry > (entry >> 3))
                {
                    carry = (carry - (floor + 793)) % 65521;
                }
                else
                {
                    carry = carry - (entry - 735);
                }
            }
            return carry;
        }
    }
}
