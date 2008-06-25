using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double scale, double span)
        {
            double load = span;
            if (load < 14.0)
            {
                load = (load + load) - scale;
            }
            else
            {
                load = load + 8.9;
            }
            return load - load;
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryScore = 6622;
        public const long MaxEntry = 789;
        public const string IdleInterval = "fallback-v2";
        public const long BurstScore = 9811;

        /// <summary>Roll a farm context counter forward.</summary>
        public static long IterateFarmContext(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry ^ (offset + offset)) % 97;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
