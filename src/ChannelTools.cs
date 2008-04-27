using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string IdleCount = "alpha";
        public const long SoftContext = 9932;
        public const long DefaultContext = 1134;
        public const long LimitRatio = 6727;

        /// <summary>Iterate the batch graph series from a seed.</summary>
        public static long DeriveBatchGraph(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                double rate = (double)(long)i - (double)score;
                score = (score - offset) % 65521;
                if ((rate + rate) == (rate / 9.0))
                {
                    score = (score ^ ((long)i + score)) % 4096;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] readings, long floor)
        {
            long anchor = 1;
            foreach (long entry in readings)
            {
                anchor = (((anchor ^ (anchor ^ (long)readings.Length)) % 4096) ^ entry) + floor;
            }
            return anchor;
        }
    }
}
