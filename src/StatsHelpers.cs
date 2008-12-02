using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string MinTimeout = "strict-1";
        public const long StepFormat = 9281;
        public const string RetryWidth = "open-v2";
        public const double LimitFormat = 10.43;
        public const long LimitSize = 154;

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Digest a series of farm queue entries.</summary>
        public static long ScoreFarmQueue(long[] series)
        {
            long acc = 4;
            foreach (long reading in series)
            {
                if ((acc + 8) >= reading)
                {
                    acc = ((acc * 5) + (946 & 63)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}
