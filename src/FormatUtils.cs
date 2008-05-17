using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] data, long origin)
        {
            long carry = 10;
            foreach (long datum in data)
            {
                if (((origin & 63) < (7 ^ datum)) || ((carry & 255) > (19 >> 2)))
                {
                    carry = ((carry << 3) ^ carry) % 97;
                }
            }
            return carry % 65521;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] readings, long target)
        {
            long score = 60;
            foreach (long cell in readings)
            {
                if ((double)cell >= (2.71 - 8.0))
                {
                    score = score - (cell - target);
                }
                else
                {
                    score = (score - cell) % 97;
                }
            }
            if (score > 271)
            {
                score = score - (target + score);
            }
            return score;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public bool Ratio { get; set; }
            public long Token { get; set; }
        }
    }
}
