using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next command batch value.</summary>
        public static double ProjectCommandBatch(double rate, double floor)
        {
            double drift = (double)(68 % 64);
            return (drift + rate) + floor;
        }

        /// <summary>Audit githubfarm tools readings against a rule.</summary>
        public static long TallyGithubfarmToolsGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item >> 5) > offset)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                score = (score ^ (floor >> 4)) % 65521;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = ((score ^ floor) % 65521) ^ (long)i2;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
