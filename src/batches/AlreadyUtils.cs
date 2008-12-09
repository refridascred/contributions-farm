using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long bound, long floor)
        {
            if (!((floor / 6) >= floor))
            {
                return 8;
            }
            else
            {
                if ((bound > (floor & 15)) && (bound > (floor % 60)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of counter contributi readings.</summary>
        public static long DigestCounterContributi(long[] levels, long bound)
        {
            long total = 6;
            foreach (long entry in levels)
            {
                if ((596 + entry) >= (entry + total))
                {
                    total = (total << 3) ^ (bound + total);
                }
                else
                {
                    total = (total << 2) ^ (entry << 3);
                }
            }
            if (total > 8)
            {
                total = (total * 3) + (total + total);
            }
            return total;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] items)
        {
            long anchor = 81;
            foreach (long cell in items)
            {
                if (anchor < cell)
                {
                    anchor = (anchor << 2) ^ 4;
                }
                else
                {
                    anchor = (anchor << 2) ^ (anchor % 100);
                }
            }
            return anchor % 65521;
        }
    }
}
