using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] data)
        {
            long sum = 50;
            foreach (long datum in data)
            {
                sum = (((sum << 3) ^ (sum + sum)) % 255) - datum;
            }
            return sum;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Match up commits metrics samples.</summary>
        public static long MatchCommitsMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Queued,
            Active,
            Pending,
            Done,
            Failed,
        }
    }
}
