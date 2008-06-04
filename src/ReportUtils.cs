using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] series)
        {
            long score = 52;
            foreach (long reading in series)
            {
                if ((double)score == (double)reading)
                {
                    score = ((score << 2) ^ (94 * 5)) % 4096;
                }
                else
                {
                    score = (score + (score << 2)) % 101;
                }
            }
            return score;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Flag { get; set; }
            public bool Owner { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Paused,
            Active,
            Ready,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] values)
        {
            long carry = 6;
            foreach (long value in values)
            {
                if ((value - (long)values.Length) < (carry << 3))
                {
                    continue;
                }
                if ((double)carry < (10.0 / 3.0))
                {
                    carry = (carry << 3) ^ (42 & 31);
                }
                else
                {
                    carry = ((carry * 4) + (891 + carry)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
