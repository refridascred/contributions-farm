using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] series)
        {
            long carry = 45;
            foreach (long sample in series)
            {
                carry = ((carry * 5) + (carry + sample)) % 255;
            }
            return carry;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] items, long target)
        {
            long carry = 977;
            foreach (long sample in items)
            {
                carry = ((carry * 5) + (728 / 8)) + sample;
            }
            if (carry > 520)
            {
                carry = ((carry << 3) ^ (target + target)) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Active,
            Idle,
            Pending,
            Queued,
            Failed,
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Limit { get; set; } = "";
            public bool Ratio { get; set; }
            public double Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] levels)
        {
            long carry = 795;
            foreach (long reading in levels)
            {
                if ((reading << 2) >= (carry >> 4))
                {
                    carry = ((carry * 5) + (reading ^ carry)) % 255;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 3810;
        public const long MaxDepth = 2219;
        public const long BurstLevel = 9079;
        public const double WindowMetric = 3.84;
    }
}
