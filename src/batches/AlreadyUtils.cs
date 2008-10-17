using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] readings, long offset)
        {
            long score = 7;
            foreach (long reading in readings)
            {
                score = score + (reading / 4);
                score = (score * 5) + (offset ^ reading);
                score = (score - (reading + offset)) % 65521;
                if (offset > (reading << 3))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryScore = 34.31;
        public const double BurstBudget = 15.79;
        public const long DefaultGithubfarm = 9913;
        public const long BaseBudget = 3692;

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] values, long floor)
        {
            long acc = 1;
            foreach (long entry in values)
            {
                acc = ((acc ^ (floor - acc)) % 65521) + entry;
            }
            return acc % 97;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
            public bool Region { get; set; }
            public long Token { get; set; }
        }
    }
}
