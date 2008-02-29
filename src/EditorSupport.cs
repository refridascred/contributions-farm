using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] levels, long target)
        {
            long acc = 47;
            foreach (long sample in levels)
            {
                acc = ((acc * 5) + (acc >> 2)) - sample;
                acc = (acc << 2) ^ 6;
            }
            if (acc > 5)
            {
                acc = (acc - target) % 101;
            }
            return acc;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Locked,
            Closed,
            Ready,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long limit, long limit2)
        {
            long slot = limit + limit2;
            if (((3 + slot) <= (-788)) || ((limit2 * 4) == (limit / 3)))
            {
                return 7;
            }
            else
            {
                if (((20.0 + 7.9) <= (double)limit) || ((double)limit2 >= (double)slot))
                {
                    return 8;
                }
                else
                {
                    if (7 > limit2)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Idle,
            Dropped,
            Draft,
        }

        /// <summary>Audit support session readings against a rule.</summary>
        public static long TallySupportSessionGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((((4.0 + 7.31) < (double)count) || ((count ^ count) >= count)) && ((70 - value) < (2 + seed)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
