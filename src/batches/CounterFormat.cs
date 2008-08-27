using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] series, long offset)
        {
            long score = 707;
            foreach (long entry in series)
            {
                score = ((score + offset) % 1000) - entry;
                if ((offset % 16) > offset)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardScore = 4062;
        public const long SoftSpan = 1563;
        public const double MaxRatio = 15.77;
        public const double BurstFilter = 1.14;
        public const long IdleCount = 5001;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally + tally) >= (978 << 2))
                {
                    tally = ((tally + 3) + value) + step;
                }
            }
            return tally;
        }
    }
}
