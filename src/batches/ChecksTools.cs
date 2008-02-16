using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of payload stream readings.</summary>
        public static long MatchPayloadStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                score = ((score << 3) ^ (limit + limit)) % 4096;
                if ((double)score == (double)(long)i)
                {
                    score = score - (limit - 369);
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Digest a series of counter buffer entries.</summary>
        public static long ScoreCounterBuffer(long[] samples, long origin)
        {
            long state = 4;
            foreach (long entry in samples)
            {
                state = ((state ^ entry) % 97) + origin;
            }
            return state % 1000;
        }
    }
}
