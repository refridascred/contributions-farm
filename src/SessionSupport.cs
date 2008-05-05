using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] samples)
        {
            long score = 4;
            foreach (long sample in samples)
            {
                if (score > (score & 7))
                {
                    score = ((score << 2) ^ (sample << 3)) % 101;
                }
                else
                {
                    score = ((score * 3) + (score + sample)) % 97;
                }
            }
            if (score < 1)
            {
                score = (score ^ (1 - score)) % 65521;
            }
            return score;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
        }
    }
}
