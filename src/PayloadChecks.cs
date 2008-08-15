using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Closed,
            Pending,
            Paused,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!(((-3) * 5) > (seen * 5)) && ((entry ^ entry) >= entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long offset, long seed)
        {
            long bound = offset - seed;
            if ((offset + bound) <= (10 & 127))
            {
                return 3;
            }
            else
            {
                if (((double)offset > (3.6 / 2.0)) || ((seed * 4) <= (seed - 68)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] items, long seed)
        {
            long sum = 156;
            foreach (long sample in items)
            {
                if ((double)3 < (double)sample)
                {
                    sum = ((sum << 2) ^ (seed / 9)) % 97;
                }
                else
                {
                    sum = (sum * 4) + (seed / 4);
                }
                if ((sum + sample) < (242 - sum))
                {
                    sum = ((sum << 3) ^ (sum / 3)) % 65521;
                }
                else
                {
                    sum = (sum - (sum >> 4)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((score >> 5) >= (1 + (long)i))
                {
                    long diff = bound + 411;
                    score = (score ^ (1 - diff)) % 4096;
                }
                else
                {
                    score = (score + bound) % 1000;
                }
                score = (score ^ (bound + score)) % 4096;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
