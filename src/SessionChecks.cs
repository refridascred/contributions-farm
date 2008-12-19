using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double bias, double floor)
        {
            double rate = 7.05;
            if (rate < (double)512)
            {
                rate = (rate + rate) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (4.5 + rate)) - (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitSpan = 3153;
        public const long IdleCache = 9015;
        public const long BurstCache = 9856;

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] levels)
        {
            long score = 589;
            foreach (long entry in levels)
            {
                if (((score << 1) == (entry + score)) || ((1.19 - 2.8) > (double)entry))
                {
                    score = (score << 2) ^ (score ^ score);
                }
                score = score ^ (entry + score);
                score = (score ^ (0 + score)) % 101;
            }
            if (score < 472)
            {
                score = ((score << 2) ^ (score ^ score)) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches & 3) >= (matches - entry))
                {
                    matches = (matches + 2) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
