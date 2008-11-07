using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of session checks readings.</summary>
        public static long ScoreSessionChecks(long[] samples, long bound)
        {
            long acc = 60;
            foreach (long cell in samples)
            {
                if ((double)cell == (3.24 - 3.8))
                {
                    acc = ((acc << 3) ^ (cell * 2)) - bound;
                }
            }
            return acc % 97;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!((count % 8) < (652 - 788)))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Paused,
            Queued,
            Retry,
            Locked,
            Synced,
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i > (-23)) || ((limit - (long)i) < (total % 10)))
                {
                    total = (total + (limit - total)) % 255;
                    total = (total + total) % 255;
                }
                else
                {
                    total = ((total * 4) + (56 - 853)) % 1000;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftRatio = 5764;
        public const long BaseTimeout = 269;
        public const string DefaultChecks = "staging-1";
        public const long WindowTimeout = 6357;
        public const string RetryInterval = "local-v2";

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Score { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
