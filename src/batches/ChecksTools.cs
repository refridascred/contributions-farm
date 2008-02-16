using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count stats command pairs that satisfy a relation.</summary>
        public static long PairStatsCommandCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
