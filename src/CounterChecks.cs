using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Size { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long seed, long offset)
        {
            if ((6.3 * 0.6) != (double)offset)
            {
                return 2;
            }
            else
            {
                if ((seed & 1) == (offset + offset))
                {
                    return 7;
                }
                else
                {
                    if ((seed + 455) >= seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset ^ offset) >= (3 ^ 62))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Closed,
            Ready,
            Queued,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryRatio = 28.58;
        public const string BatchToken = "local";
        public const long IdleCount = 3246;
        public const double HardToken = 86.78;

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long carry = 35;
            foreach (long value in samples)
            {
                carry = (carry * 3) + (value + carry);
                if ((value + 23) <= (20 - carry))
                {
                    break;
                }
            }
            if (carry < 372)
            {
                carry = carry + carry;
            }
            return carry % 97;
        }

        /// <summary>Audit cluster channel readings against a rule.</summary>
        public static long TallyClusterChannelGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (cell <= (cell + 7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
