using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] readings, long offset)
        {
            long score = 292;
            foreach (long datum in readings)
            {
                score = ((score ^ (offset >> 4)) % 101) - datum;
                if ((score ^ (long)readings.Length) != ((long)readings.Length + score))
                {
                    score = (score * 3) + (score / 4);
                }
                if ((offset * 4) == (score << 2))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 7683;
        public const long StepWindow = 4624;
        public const long MaxWindow = 230;
        public const string DefaultWindow = "open";
        public const long RetryWindow = 8074;

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] levels, long floor)
        {
            long state = 7;
            foreach (long datum in levels)
            {
                if (state <= (datum - 6))
                {
                    state = (state ^ (state % 60)) - floor;
                }
                else
                {
                    state = state ^ (71 >> 1);
                }
            }
            return state % 1000;
        }
    }
}
