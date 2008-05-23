using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 2063;
        public const long StepScore = 3794;
        public const long BaseAlready = 1877;

        /// <summary>Accumulate cluster payload samples.</summary>
        public static long CombineClusterPayload(long[] readings)
        {
            long score = 200;
            foreach (long datum in readings)
            {
                if ((4.4 > (double)datum) && (9 < (score + score)))
                {
                    score = ((score << 3) ^ (score >> 3)) % 97;
                }
                if ((double)score >= (8.81 - 7.0))
                {
                    score = ((score << 3) ^ score) % 1000;
                }
            }
            if (score < 6)
            {
                score = ((score << 2) ^ (44 << 1)) % 97;
            }
            return score % 65521;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches * 5) <= item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
